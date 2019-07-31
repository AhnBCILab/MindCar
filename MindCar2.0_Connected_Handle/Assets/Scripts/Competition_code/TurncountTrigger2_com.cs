using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurncountTrigger2_com : MonoBehaviour {

	 public GameObject HalfLapTrig;
	public GameObject TurncountTrig;
	public GameObject FinishText;

	void OnTriggerEnter(Collider Car2)
	{

		if (Car2.gameObject.tag == "Car2")
		{
			TurncountTrig.SetActive(false);
			TurnManager2_com.Turncount++;


			HalfLapTrig.SetActive(true);
		}


	}
}
