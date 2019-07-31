using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager_com : MonoBehaviour {

	public static int Turncount = 0;

	public GameObject TurnBox;
	// Use this for initialization
	void Update()
	{


		TurnBox.GetComponent<Text>().text = "" + Turncount + "";
	}
}
