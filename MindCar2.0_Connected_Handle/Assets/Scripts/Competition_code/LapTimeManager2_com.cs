using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager2_com : MonoBehaviour
{

	public static int MinuteCount2p;
	public static int SecondCount2p;
	public static float MilliCount2p;
	public static string MilliDisplay2p;

	public GameObject MinuteBox;
	public GameObject SecondBox;
	public GameObject MilliBox;

	void Update()
	{
        MilliCount2p += Time.deltaTime * 10;
        MilliDisplay2p = MilliCount2p.ToString("F0");
        MilliBox.GetComponent<Text>().text = "" + MilliDisplay2p;

        if (MilliCount2p >= 10)
		{
            MilliCount2p = 0;
            SecondCount2p += 1;
		}

        if (SecondCount2p <= 9)
		{
            SecondBox.GetComponent<Text>().text = "0" + SecondCount2p + ".";
		}
		else
		{
            SecondBox.GetComponent<Text>().text = "" + SecondCount2p + ".";
		}

        if (SecondCount2p >= 60)
		{
            SecondCount2p = 0;
            MinuteCount2p += 1;
		}

        if (MinuteCount2p <= 9)
		{
            MinuteBox.GetComponent<Text>().text = "0" + MinuteCount2p + ":";
		}
		else
		{
            MinuteBox.GetComponent<Text>().text = "" + MinuteCount2p + ":";
		}
	}





}