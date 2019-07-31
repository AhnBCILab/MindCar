using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager_com : MonoBehaviour
{

	public static int MinuteCount1p;
    public static int SecondCount1p;
    public static float MilliCount1p;
    public static string MilliDisplay1p;

    public GameObject MinuteBox;
	public GameObject SecondBox;
	public GameObject MilliBox;

	void Update()
	{
        MilliCount1p += Time.deltaTime * 10;
        MilliDisplay1p = MilliCount1p.ToString("F0");
        MilliBox.GetComponent<Text>().text = "" + MilliDisplay1p;

        if (MilliCount1p >= 10)
		{
            MilliCount1p = 0;
            SecondCount1p += 1;
		}

        if (SecondCount1p <= 9)
		{
            SecondBox.GetComponent<Text>().text = "0" + SecondCount1p + ".";
		}
		else
		{
            SecondBox.GetComponent<Text>().text = "" + SecondCount1p + ".";
		}

        if (SecondCount1p >= 60)
		{
            SecondCount1p = 0;
            MinuteCount1p += 1;
		}

        if (MinuteCount1p <= 9)
		{
            MinuteBox.GetComponent<Text>().text = "0" + MinuteCount1p + ":";
		}
		else
		{
            MinuteBox.GetComponent<Text>().text = "" + MinuteCount1p + ":";
		}
	}





}