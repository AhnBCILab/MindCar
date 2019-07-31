using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNameShow : MonoBehaviour {

	public static string userName;
	public Text NameText;

	// Use this for initialization
	void Start () {	
		NameText.GetComponent<Text>().text = userName;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
