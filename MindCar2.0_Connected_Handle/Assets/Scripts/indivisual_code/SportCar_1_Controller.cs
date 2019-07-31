using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SportCar_1_Controller : MonoBehaviour {

	public GameObject Marker;
	private float timePassed;
    public AudioSource CarDefault;


	// Use this for initialization
    public List<double> signal = new List<double>();
    int command;

    //----------------------------------
    int BeginningCommmand = 1;  //1
    int FinalCommmand = 10;     //10
    int Index = 0;
    float speed = 0;
  
    //----------------------------------   

	// Update is called once per frame

    public float xAxes;
    void Start()
    {
        //not ignoring xinput in this example 
        LogitechGSDK.LogiSteeringInitialize(false);
        Debug.Log(LogitechGSDK.LogiSteeringInitialize(false));

    }  		

	void Update(){

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



        /*
         * When racing wheel is connected and available
         */

        if (LogitechGSDK.LogiUpdate() && LogitechGSDK.LogiIsConnected(0))
        {
            //Debug.Log("logitech is connected!");
            LogitechGSDK.DIJOYSTATE2ENGINES rec;
            rec = LogitechGSDK.LogiGetStateCSharp(0);

            xAxes = rec.lX;
            //Quaternion Right = Quaternion.identity;
            //Right.eulerAngles = new Vector3(0, 80 + (xAxes / 5000 * 80), 0);
            LogitechGSDK.LogiPlaySpringForce(0, 0, 50, 20);
            transform.Rotate(new Vector3(0, xAxes / 4000, 0));

            //--------------------Set Speed of Car------------------------------- 

            switch (command)
            {
                case 0: speed = 2.0f; break;
                case 1: speed = 2.5f; break;
                case 2: speed = 3.0f; break;
                case 3: speed = 3.3f; break;
                case 4: speed = 3.7f; break;
                case 5: speed = 4.0f; break;
                case 6: speed = 4.2f; break;
                case 7: speed = 4.3f; LogitechGSDK.LogiPlayDirtRoadEffect(0, 5); break;
                case 8: speed = 4.5f; LogitechGSDK.LogiPlayDirtRoadEffect(0, 10); break;
                case 9: speed = 4.8f; LogitechGSDK.LogiPlayDirtRoadEffect(0, 14); break;
                case 10: speed = 5.0f; LogitechGSDK.LogiPlayDirtRoadEffect(0, 18); break;
                default: break;
            }

            CarDefault.volume = 0.5f + (speed / 10f);

            transform.Translate(new Vector3(0, 0, speed));

        }


        /*
         * When racing wheel is not connected so unavailable
         */
        else {

            switch (command)
            {
                case 0: speed = 2.0f; break;
                case 1: speed = 2.5f; break;
                case 2: speed = 3.0f; break;
                case 3: speed = 3.3f; break;
                case 4: speed = 3.7f; break;
                case 5: speed = 4.0f; break;
                case 6: speed = 4.2f; break;
                case 7: speed = 4.3f; break;
                case 8: speed = 4.5f; break;
                case 9: speed = 4.8f; break;
                case 10: speed = 5.0f; break;
                default: break;
            }

            //if (Input.GetKey(KeyCode.UpArrow))
                transform.Translate(new Vector3(0, 0, speed));

            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
                timePassed = Time.time;

            if (Input.GetKey(KeyCode.RightArrow) && (Time.time - timePassed) < 0.7f)
                transform.Rotate(new Vector3(0, 2, 0));

            if (Input.GetKey(KeyCode.LeftArrow) && (Time.time - timePassed) < 0.7f)
                transform.Rotate(new Vector3(0, -2, 0));


            CarDefault.volume = 0.5f + (speed / 10f);

        }





		Marker.transform.position = new Vector3(this.transform.position.x, -1290, this.transform.position.z);

        SpeedobarConverter.ShowSpeed(speed, 0, 10);
	}




    void Stop()
    {
        LogitechGSDK.LogiSteeringShutdown();
    }


}

