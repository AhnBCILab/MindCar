using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   
    public void Restart1()
    {
        TrainingController.mode = 0;
	}

    public void Restart2()
    {
        TrainingController.mode = 1;

    }

    public void Restart3()
    {
        TrainingController.mode = 2;
    }

}
