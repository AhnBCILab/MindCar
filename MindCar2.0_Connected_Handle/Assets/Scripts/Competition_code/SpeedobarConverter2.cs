using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedobarConverter2 : MonoBehaviour
{

    static float minSpeed = 0.0f;
    static float maxSpeed = 1.0f;
    static float xscale = 0.0f;
    static SpeedobarConverter2 Speedobar;

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

        //UnityEngine.Debug.Log(convertedSpeed + "입니다.");

        if (convertedSpeed < Speedobar.transform.localScale.x) // speedobar의 길이가 짧아짐
        {
            xscale = 1 - convertedSpeed;
            Speedobar.transform.localScale -= new Vector3(xscale, 0, 0);
        }
        else if (convertedSpeed > Speedobar.transform.localScale.x)
        {
            xscale = convertedSpeed - Speedobar.transform.localScale.x;
            Speedobar.transform.localScale += new Vector3(xscale, 0, 0);

        }

    }
}
