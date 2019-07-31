using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;
	public GameObject TurncountTrig;

	void OnTriggerEnter()
	{
		TurncountTrig.SetActive(true);

		HalfLapTrig.SetActive(false);
		if (TurnManager.Turncount == 2)
		{
			
			LapCompleteTrig.SetActive(true);
		}
	}


}
