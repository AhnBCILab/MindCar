using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScene : MonoBehaviour {

	public InputField x;
	private string name;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void SendName1 (){
		name = x.text;		
		PlayerNameShow.userName = name;
        TrainingController.mode = 0;
	}

    public void SendName2()
    {
        name = x.text;
        PlayerNameShow.userName = name;
        TrainingController.mode = 1;

    }

}
