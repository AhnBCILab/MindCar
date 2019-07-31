using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedobarConverter_auto : MonoBehaviour
{

    static float minSpeed = 0.0f;
    static float maxSpeed = 1.0f;

    static float xscale = 0.0f;
    static SpeedobarConverter_auto Speedobar;

    // Use this for initialization
    void Start()
    {
        Speedobar = this;

    }

    // Update is called once per frame
    void Update()
    {
    }

    public static void ShowSpeed(float speed, float min, float max)
    {
        // float ang = Mathf.Lerp(minAngle, maxAngle, Mathf.InverseLerp(min, max, speed));
        float convertedSpeed = Mathf.Lerp(maxSpeed, minSpeed, Mathf.InverseLerp(min, max, speed));

        if (convertedSpeed < Speedobar.transform.localScale.x)
            Speedobar.transform.localScale -= new Vector3(0.05f, 0, 0); //this.transform.localScale += new Vector3(0.001f, 0, 0);
        else if (convertedSpeed > Speedobar.transform.localScale.x)
        {
            xscale = convertedSpeed - Speedobar.transform.localScale.x;
            Speedobar.transform.localScale += new Vector3(xscale, 0, 0);

        }
    }
}
