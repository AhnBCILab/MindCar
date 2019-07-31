using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger_com : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;
	public GameObject TurncountTrig;


	void OnTriggerEnter(Collider Car1)
	{
		if (Car1.gameObject.tag == "Car1")
		{

			TurncountTrig.SetActive(true);

			HalfLapTrig.SetActive(false);
			if (TurnManager_com.Turncount == 2)
			{

				LapCompleteTrig.SetActive(true);
			}
		}

	}


}
