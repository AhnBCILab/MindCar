using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class LapCompleteTrigger_com : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;
 
	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;
    public GameObject CarControls;
	public GameObject LapTimeBox;
	public GameObject FinishText;
    public GameObject FinishPanel;
    public GameObject Tirgger_2p;

    string savePath = @"U:\ov\time\record_p1.txt";
    string textValue; 


	// public GameObject MilliDisplay;
	

    UIVA_Client theClient;
    int buttonIndexNum = 3;   // End condition is 3.
    public static bool Triggered1p = false;

    void OnTriggerEnter(Collider Car1)
    {
        if (Car1.tag == "Car1")
        {
            Triggered1p = true;
            FinishText.SetActive(true);
            CarControls.SetActive(true);

            // Stimulate when the game is over. 
            var Client = GameObject.Find("PressController").GetComponent<ForPress>();
            theClient = Client.theClient;

            // var FinishVar = GameObject.Find("FinishPanelManager").GetComponent<FinishPanelManager_com>();
            FinishPanelManager_com.MinuteCountBest1p = LapTimeManager_com.MinuteCount1p;
            FinishPanelManager_com.SecondCountBest1p = LapTimeManager_com.SecondCount1p;
            FinishPanelManager_com.MilliCountBest1p = LapTimeManager_com.MilliCount1p;
            textValue = LapTimeManager_com.MinuteCount1p + ":" + LapTimeManager_com.SecondCount1p + ":" + LapTimeManager_com.MilliCount1p;
            System.IO.File.WriteAllText(savePath, textValue, Encoding.Default);

            if (LapCompleteTrigger2_com.Triggered2p == true)
            {
                FinishPanel.SetActive(true);
                Debug.Log("Competition is finished!");
                theClient.PutOpenvibeButton(0);  // theClient.Press(buttonIndexNum);
            }





            LapTimeManager_com.MinuteCount1p = 0;
            LapTimeManager_com.SecondCount1p = 0;
            LapTimeManager_com.MilliCount1p = 0;

            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);






        }
    }


	

}
