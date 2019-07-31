using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest_auto : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col)
	{
		
			if (col.gameObject.tag == "fence")
		{
			if (Input.GetKey(KeyCode.UpArrow))
				transform.Translate(new Vector3(0, 0, -10));
			else if (Input.GetKey(KeyCode.DownArrow))
				transform.Translate(new Vector3(0, 0, 10));
		}
		

	}

	void OnCollisionStay(Collision col)
	{
		
			if (col.gameObject.tag == "fence")
		{
			if (Input.GetKey(KeyCode.UpArrow))
				transform.Translate(new Vector3(0, 0, -10));
			else if(Input.GetKey(KeyCode.DownArrow))
				transform.Translate(new Vector3(0, 0, 10));
		}

	}

	void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "fence")
		{
			if (Input.GetKey(KeyCode.UpArrow))
				transform.Translate(new Vector3(0, 0, -10));
			else if (Input.GetKey(KeyCode.DownArrow))
				transform.Translate(new Vector3(0, 0, 10));
		}
	}
}
