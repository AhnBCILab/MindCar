using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FinishPanelManager_com : MonoBehaviour {
    public static int MinuteCountBest1p;
    public static int SecondCountBest1p;
    public static float MilliCountBest1p;
    public static string MilliDisplayBest1p;



    public GameObject MinuteDisplay1p;
    public GameObject SecondDisplay1p;
    public GameObject MilliDisplay1p;

    public static int MinuteCountBest2p;
    public static int SecondCountBest2p;
    public static float MilliCountBest2p;
    public static string MilliDisplayBest2p;

    public GameObject MinuteDisplay2p;
    public GameObject SecondDisplay2p;
    public GameObject MilliDisplay2p;

	// Use this for initialization
	void Start () {
      
		
	}
	
	// Update is called once per frame
	void Update () {

       

        //1player
        if (SecondCountBest1p <= 9)
        {
            SecondDisplay1p.GetComponent<Text>().text = "0" + SecondCountBest1p + ".";
        }
        else
        {
            SecondDisplay1p.GetComponent<Text>().text = "" + SecondCountBest1p + ".";
        }

        if (MinuteCountBest1p <= 9)
        {
            MinuteDisplay1p.GetComponent<Text>().text = "0" + MinuteCountBest1p + ":";
        }
        else
        {
            MinuteDisplay1p.GetComponent<Text>().text = "" + MinuteCountBest1p + ":";
        }

        MilliDisplayBest1p = MilliCountBest1p.ToString("F0");
        MilliDisplay1p.GetComponent<Text>().text = "" + MilliDisplayBest1p;


        //2player
        if (SecondCountBest2p <= 9)
        {
            SecondDisplay2p.GetComponent<Text>().text = "0" + SecondCountBest2p + ".";
        }
        else
        {
            SecondDisplay2p.GetComponent<Text>().text = "" + SecondCountBest2p + ".";
        }

        if (MinuteCountBest2p <= 9)
        {
            MinuteDisplay2p.GetComponent<Text>().text = "0" + MinuteCountBest2p + ":";
        }
        else
        {
            MinuteDisplay2p.GetComponent<Text>().text = "" + MinuteCountBest2p + ":";
        }

        MilliDisplayBest2p = MilliCountBest2p.ToString("F0");
        MilliDisplay2p.GetComponent<Text>().text = "" + MilliDisplayBest2p;
	}
}
