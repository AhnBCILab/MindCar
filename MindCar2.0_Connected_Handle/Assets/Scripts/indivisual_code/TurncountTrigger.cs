using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TurncountTrigger : MonoBehaviour {
	
	public GameObject HalfLapTrig;
	public GameObject TurncountTrig;
	public GameObject FinishText;

	void OnTriggerEnter()
	{
		TurncountTrig.SetActive(false);
		TurnManager.Turncount++;


		HalfLapTrig.SetActive(true);

	
	}
}
