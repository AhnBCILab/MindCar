using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteTrigger_auto : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;

	public GameObject LapTimeBox;

    UIVA_Client theClient;

    public GameObject FinishPanel;
    public Text NameText;
    public AudioSource CarDefault;
    public GameObject CarControls;

    //Save Text file
    string savePath = @"U:\ov\time\AutoRecord.txt";
    string textValue;
    //UIVA_Client theClient;
    int buttonIndexNum = 3;   // End condition is 3.
    

	void OnTriggerEnter()
	{
        CarDefault.Pause();
        NameText.GetComponent<Text>().enabled = false;
        FinishPanel.SetActive(true);

        CarControls.SetActive(true);

        var Client = GameObject.Find("PressController").GetComponent<ForPress>();
        Debug.Log("Individual is finished!");
        theClient = Client.theClient;

        theClient.PutOpenvibeButton(0);  // Client.theClient.Press(buttonIndexNum);

        FinalPanelManager_auto.MinuteCount = LapTimeManager_auto.MinuteCount;
        FinalPanelManager_auto.SecondCount = LapTimeManager_auto.SecondCount;
        FinalPanelManager_auto.MilliCount = LapTimeManager_auto.MilliCount;

        textValue = LapTimeManager_auto.MinuteCount + ":" + LapTimeManager_auto.SecondCount + ":" + LapTimeManager_auto.MilliCount;
        System.IO.File.WriteAllText(savePath, textValue, Encoding.Default);

		LapTimeManager_auto.MinuteCount = 0;
		LapTimeManager_auto.SecondCount = 0;
		LapTimeManager_auto.MilliCount = 0;

		HalfLapTrig.SetActive(true);
		LapCompleteTrig.SetActive(false);
	}

}
