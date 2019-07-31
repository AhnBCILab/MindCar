using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScene_com : MonoBehaviour {

    public InputField x;
    private string name1;
    public InputField y;
    private string name2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SendTwoName()
    {
        name1 = x.text;
        PlayerNameShow_com.userName1 = name1;
        name2 = y.text;
        PlayerNameShow_com.userName2 = name2;

        TrainingController.mode = 2;
    }

}
