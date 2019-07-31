using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger_auto : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;
	public GameObject TurncountTrig;

	void OnTriggerEnter()
	{
		TurncountTrig.SetActive(true);

		HalfLapTrig.SetActive(false);
		if (TurnManager_auto.Turncount == 2)
		{
			
			LapCompleteTrig.SetActive(true);
		}
	}


}
