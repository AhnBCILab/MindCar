using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using System;




public class SportCar_1_Controller_com : MonoBehaviour
{

    public GameObject Marker1;
    private float timePassed;
    // Use this for initialization
    public Vector3[] waypoints;
    private Vector3 currPosition;
    private Quaternion currRotation;
    private int waypointIndex = 0;
    public Transform target;
    private float angle2 = 0;

    public double raw_command;

    public float baseline_from_rest;
    public float std_baseline;
    public float max_baseline;
    public float min_baseline;

    public float start_time;
    public float maintain_value;


    // Use this for initialization
    public List<double> signal = new List<double>();
    public int command;
    public float Speed1p;
    void Start()
    {

        waypoints = new Vector3[22];
    }

    double Meas_Angle(Vector3 P1, Vector3 P2, Vector3 P3)
    {

        double a, b, c;
        double Angle, temp;

        a = Math.Sqrt(Math.Pow(P1.x - P3.x, 2) + Math.Pow(P1.z - P3.z, 2));
        b = Math.Sqrt(Math.Pow(P1.x - P2.x, 2) + Math.Pow(P1.z - P2.z, 2));
        c = Math.Sqrt(Math.Pow(P2.x - P3.x, 2) + Math.Pow(P2.z - P3.z, 2));

        temp = (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);

        Angle = Math.Acos(temp);
        Angle = Angle * (180 / Math.PI);

        return Angle;
    }

    float kh_get_angle(Vector3 P1, Vector3 P2, Vector3 P3)
    {
        // P1: current car position, P2: next car position way point, P3: next way point
        // Our goal: calculate angle between Line(P1-P2) and Line(P2-P3)
        // we only use x and z location since y(height) is fixed
        float angle;
        float tmp_sinsoidal;
        float numerator, denominator;
        float diff_x_12, diff_x_13;
        float diff_z_12, diff_z_13;
        float kh_epsilon = 0.00001f;
        diff_x_12 = -(P1.x - P2.x);
        diff_x_13 = -(P1.x - P3.x);

        diff_z_12 = -(P1.z - P2.z);
        diff_z_13 = -(P1.z - P3.z);
        // now unit vectors are followings:
        // u_line12 = (diff_x_12, diff_z_12)
        // u_line13 = (diff_x_13, diff_z_13)

        // angle between two lines
        // cos(theta) = {u_line12 * u_line13 (inner product)} / {abs(u_line12) x abs(u_line13)}
        numerator = diff_x_12 * diff_x_13 + diff_z_12 * diff_z_13;
        denominator = Mathf.Sqrt(Mathf.Pow(diff_x_12, 2) + Mathf.Pow(diff_z_12, 2)) * Mathf.Sqrt(Mathf.Pow(diff_x_13, 2) + Mathf.Pow(diff_z_13, 2));
        if (denominator < kh_epsilon)
            denominator = kh_epsilon;
        tmp_sinsoidal = (float)(numerator / denominator);

        angle = Mathf.Acos(tmp_sinsoidal);
        angle = angle * (180 / Mathf.PI); // radian to degress
        return angle;
    }


    // Update is called once per frame

    //----------------------------------
    int BeginningCommmand = 1;  //1
    int FinalCommmand = 10;     //10
    int Index = 0;
    int speed = 0;

    //---------------------------------- 



    void Update()
    {
        currPosition = transform.position;
        currRotation = transform.rotation;
        // Stimulate for starting check and trainning time check 
        var theClient = GameObject.Find("PressController").GetComponent<ForPress>();
        signal = theClient.signal;

        //--------------------------------------------------------------------------    
        if (signal[0] < BeginningCommmand || signal[0] > FinalCommmand)
        {  // If exception, than default case. And checking the default command(protocol == 0).
            command = 0;
        }
        else
        {
            for (int i = BeginningCommmand; i <= FinalCommmand; i++)
            {
                if (signal[0] >= i && signal[0] < (i + 1))  // If it was 1, then (1 <= x < 2).
                {
                    command = i;
                    break;
                }

            }
        }
        //-------------------------------------------------------------------------- 
        if (command == 0)
        {
            Speed1p = 2;
        }
        else if (command == 1)
        {
            Speed1p = 2.5f;
        }
        else if (command == 2)
        {
            Speed1p = 3.0f;
        }
        else if (command == 3)
        {
            Speed1p = 3.3f;
        }
        else if (command == 4)
        {
            Speed1p = 3.7f;
        }
        else if (command == 5)
        {
            Speed1p = 4.0f;
        }
        else if (command == 6)
        {
            Speed1p = 4.2f;
        }
        else if (command == 7)
        {
            Speed1p = 4.3f;
        }
        else if (command == 8)
        {
            Speed1p = 4.5f;
        }
        else if (command == 9)
        {
            Speed1p = 4.8f;
        }
        else
        {
            Speed1p = 5.0f;
        }




        if (waypointIndex < waypoints.Length)
        {
            // moving forward
            //transform.position = Vector3.MoveTowards(currPosition, waypoints[waypointIndex], speed);
            // calculating rotation angle

            Vector3 standard = new Vector3(currPosition.x, currPosition.y, currPosition.z + 20);
            /*
            double angle = Meas_Angle( standard, currPosition, waypoints[waypointIndex]);	
            if ( waypoints[waypointIndex].x - currPosition.x < 0)
                angle = 360 - angle;
            */

            Quaternion Right = Quaternion.identity;
            //Right.eulerAngles = new Vector3(0, (float)angle, 0);
            Quaternion Current = Quaternion.identity;
            /*
            if (transform.eulerAngles.y != 0f)
            {
                angle2 = transform.eulerAngles.y;
            }*/
            angle2 = transform.eulerAngles.y;
            Current.eulerAngles = new Vector3(0, angle2, 0);

            float kh_angle = kh_get_angle(currPosition, standard, waypoints[waypointIndex]);
            kh_angle = Mathf.Round(kh_angle * Mathf.Pow(10, 4)) * 0.0001f;

            if (waypoints[waypointIndex].x - currPosition.x < 0)
            {
                kh_angle = 360.0f - kh_angle; // reverse?
            }
            angle2 = Mathf.Round(angle2 * Mathf.Pow(10, 4)) * 0.0001f;

            Right.eulerAngles = new Vector3(0, kh_angle, 0);


            //transform.rotation = Quaternion.Slerp(Current, Right, Time.deltaTime * 6.0f);
            transform.Translate(new Vector3(0, 0, (int)Speed1p)); // move forward (only z-axis)

            var dir_right = Quaternion.Euler(0, 55.0f, 0) * transform.forward;
            var dir_left = Quaternion.Euler(0, -55.0f, 0) * transform.forward;
            Ray ray = new Ray(this.transform.position, this.transform.forward);
            /*
            Ray ray_right = new Ray(this.transform.position, (this.transform.right + this.transform.forward).normalized);
            Ray ray_left = new Ray(this.transform.position, (this.transform.forward - this.transform.right).normalized);
            */
            Ray ray_right = new Ray(this.transform.position, dir_right);
            Ray ray_left = new Ray(this.transform.position, dir_left);
            //transform.ri
            RaycastHit hit_forward; // forward
            RaycastHit hit_right;
            RaycastHit hit_left;
            float diff_distance = 0;

            Physics.Raycast(ray, out hit_forward, 1000);
            Physics.Raycast(ray_right, out hit_right, 1000);
            Physics.Raycast(ray_left, out hit_left, 1000);
            diff_distance = hit_left.distance - hit_right.distance;

            // ------------------ Wheel direction control using Unity Raycast features
            // Raycast shoots layser to the assigned direction and measrues distance
            // Raycast information: forward, forward + right, and forward + left
            // Case:
            // - when left distance is shorter than right distance
            //  : turn right
            // - when right distance is shorter than left distance
            //  : turn left
            // now turning step is optimized in case of speed=3 (normalization is done in terms of 3)

            if (diff_distance > 15.0f) // control sensitivity level
            {
                transform.Rotate(new Vector3(0, -1.2f * (int)Speed1p / 3.0f, 0)); // turn left with fine steps
            }
            else if (diff_distance < -15.0f) // control sensitivity level
            {
                transform.Rotate(new Vector3(0, 1.2f * (int)Speed1p / 3.0f, 0)); // turn right with fine steps     
            }
            /*
            Debug.Log("forward:"+ hit_forward.distance+" left:" + hit_left.distance + " right:" + hit_right.distance + " diff:" +
                diff_distance+ " speed: "+speed);
            */


            if (Vector3.Distance(waypoints[waypointIndex], currPosition) <= 0.01f)
            {
                waypointIndex++;
                if (waypointIndex == 21)
                    waypointIndex = 0;
            }




            Marker1.transform.position = new Vector3(this.transform.position.x, -1290, this.transform.position.z);

            SpeedobarConverter1.ShowSpeed((int)Speed1p, 0, 10);

        }
    }
}


