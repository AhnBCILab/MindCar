using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger2_com : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;
	public GameObject TurncountTrig;


	void OnTriggerEnter(Collider Car2)
	{
		if (Car2.gameObject.tag == "Car2")
		{

			TurncountTrig.SetActive(true);

			HalfLapTrig.SetActive(false);
			if (TurnManager2_com.Turncount == 2)
			{

				LapCompleteTrig.SetActive(true);
			}
		}

	}

}
