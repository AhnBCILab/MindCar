using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalPanelManager : MonoBehaviour {
    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplayindi;


    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;


	// Use this for initialization
	void Start () {
       

		
	}
	
	// Update is called once per frame
	void Update () {

        if (SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + SecondCount + ".";
        }

        if (MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + MinuteCount + ":";
        }

        MilliDisplayindi = MilliCount.ToString("F0");
        MilliDisplay.GetComponent<Text>().text = "" + MilliDisplayindi;

		
	}
}
