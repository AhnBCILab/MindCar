using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class ForPress : MonoBehaviour {
    // For communication with UIVA_Client ----------------------------
    public UIVA_Client theClient;
    string ipUIVAServer = "127.0.0.1";

    // analog data
    public DateTime analogTS;
    public int numOfChannels;
    public List<double> signal = new List<double>();

    public float timeCount = 0f;

    bool stimForInit = true;
    bool stimForTrain = true;
    public double trainningTime = 0.01f;  // 30.0
    int buttonIndexNum = 0;   // Individual's button number is 0.


	// Use this for initialization
	void Start () {
        theClient = new UIVA_Client(ipUIVAServer);
      
	}
	
	// Update is called once per frame
	void Update () {
        // For getting the data of epoc 

        theClient.GetOpenvibeAnalog(out analogTS, out numOfChannels, out signal);
        // Timer
        timeCount += Time.deltaTime;
        if (TrainingController.mode == 0 || TrainingController.mode == 1)
        {
            if (timeCount > trainningTime && stimForTrain)   
            {
                Debug.Log("Time is up, Trainning is finished!");
                theClient.PutOpenvibeButton(0); // theClient.Press(buttonIndexNum);
                stimForTrain = false;

            }
        }

        if (TrainingController.mode == 2)
        {
            buttonIndexNum = 1;
            if (timeCount > trainningTime && stimForTrain)   
            {
                Debug.Log("Time is up, Trainning is finished!");
                theClient.PutOpenvibeButton(0); // theClient.Press(buttonIndexNum);
                stimForTrain = false;
           
            }
        }
	}
}
