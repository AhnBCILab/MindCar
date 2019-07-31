using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNameShow_com : MonoBehaviour {

    public static string userName1;
    public Text NameText1;
    public static string userName2;
    public Text NameText2;

	// Use this for initialization
	void Start () {
        NameText1.GetComponent<Text>().text = userName1;
        NameText2.GetComponent<Text>().text = userName2;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
