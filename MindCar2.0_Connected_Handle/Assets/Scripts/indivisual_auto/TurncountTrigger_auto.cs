using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TurncountTrigger_auto : MonoBehaviour {
	
	public GameObject HalfLapTrig;
	public GameObject TurncountTrig;
	public GameObject FinishText;
    public float time_attack;
    public float time_current;
    int buttonIndexNum = 2;   //  n/laps

    void OnTriggerEnter()
	{
        TurncountTrig.SetActive(false);
		TurnManager_auto.Turncount++;


		HalfLapTrig.SetActive(true);
        
    }
}
