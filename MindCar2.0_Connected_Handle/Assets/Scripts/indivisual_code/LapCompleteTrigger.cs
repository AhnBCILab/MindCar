using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteTrigger : MonoBehaviour {

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
    string savePath = @"U:\ov\time\HandleRecord.txt";
    string textValue; 

    int buttonIndexNum = 3;   // End condition is 3.


	void OnTriggerEnter()
	{
        // Stimulate when the game is over. 
        CarDefault.Pause();
        NameText.GetComponent<Text>().enabled = false;
        FinishPanel.SetActive(true);
        
        CarControls.SetActive(true);

        var Client = GameObject.Find("PressController").GetComponent<ForPress>();
        Debug.Log("Individual is finished!");
        theClient = Client.theClient;

        theClient.PutOpenvibeButton(0); // theClient.Press(buttonIndexNum);

        FinalPanelManager.MinuteCount = LapTimeManager.MinuteCount;
        FinalPanelManager.SecondCount = LapTimeManager.SecondCount;
        FinalPanelManager.MilliCount = LapTimeManager.MilliCount;

		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;

		HalfLapTrig.SetActive(true);
		LapCompleteTrig.SetActive(false);


		//FinishText.GetComponent<Text>().text = "FINISH";
		//FinishText.SetActive(true);
        

	}

}
