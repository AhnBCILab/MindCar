using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {
    public GameObject M;
	// Use this for initialization
	void Start () {

        DontDestroyOnLoad(M) ;
    
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
