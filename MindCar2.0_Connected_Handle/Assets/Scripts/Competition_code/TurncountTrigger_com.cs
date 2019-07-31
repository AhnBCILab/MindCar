using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TurncountTrigger_com : MonoBehaviour {
	
	public GameObject HalfLapTrig;
	public GameObject TurncountTrig;
	public GameObject FinishText;

	void OnTriggerEnter(Collider Car1)
	{
		if (Car1.gameObject.tag == "Car1")
		{
			TurncountTrig.SetActive(false);
			TurnManager_com.Turncount++;


			HalfLapTrig.SetActive(true);

		}
	
	}
}
