using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteTrigger2_com : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;
  
	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;

	public GameObject LapTimeBox;
    public GameObject CarControls2;
	public GameObject FinishText;
    public GameObject FinishPanel;
    public GameObject Tirgger_1p;
	// public GameObject MilliDisplay;
	// public GameObject MilliDisplay;

    string savePath = @"U:\ov\time\record_p2.txt";
    string textValue; 
   

    UIVA_Client theClient;
    int buttonIndexNum = 3;   // End condition is 3.

    public static bool Triggered2p = false;
    void OnTriggerEnter(Collider Car2)
    {
        if (Car2.tag == "Car2")
        {
            Triggered2p = true;
            FinishText.SetActive(true);
            CarControls2.SetActive(true);

            // Stimulate when the game is over. 
            var Client = GameObject.Find("PressController").GetComponent<ForPress>();
            theClient = Client.theClient;
            FinishPanelManager_com.MinuteCountBest2p = LapTimeManager2_com.MinuteCount2p;
            FinishPanelManager_com.SecondCountBest2p = LapTimeManager2_com.SecondCount2p;
            FinishPanelManager_com.MilliCountBest2p = LapTimeManager2_com.MilliCount2p;

            textValue = LapTimeManager2_com.MinuteCount2p + ":" + LapTimeManager2_com.SecondCount2p + ":" + LapTimeManager2_com.MilliCount2p;
            System.IO.File.WriteAllText(savePath, textValue, Encoding.Default);
            // var Trig1P = GameObject.Find("LapCompleteTrigger").GetComponent<LapCompleteTrigger_com>();

            if (LapCompleteTrigger_com.Triggered1p == true)
            {
                FinishPanel.SetActive(true);
                Debug.Log("COmpetition is finished!");
                theClient.PutOpenvibeButton(0);  // theClient.Press(buttonIndexNum);
            }




            LapTimeManager2_com.MinuteCount2p = 0;
            LapTimeManager2_com.SecondCount2p = 0;
            LapTimeManager2_com.MilliCount2p = 0;

            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);



            FinishText.SetActive(true);

        }
    }

	
}
