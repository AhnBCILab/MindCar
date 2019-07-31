using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Countdown : MonoBehaviour {

	public GameObject CountDown;
	public AudioSource GetReady;
	public AudioSource GoAudio;
    public AudioSource StartEngine;
    public AudioSource CarDefault;
    
    public GameObject LapTimer;
	public GameObject CarControls;
	public GameObject Minimap;
    public int precision = 20;
   
	void Start()
	{
		StartCoroutine(CountStart()); 
	}


	IEnumerator CountStart()
	{

      
		yield return new WaitForSeconds(0.5f);
		CountDown.GetComponent<Text>().text = "3";
		GetReady.Play();
		CountDown.SetActive(true);
		yield return new WaitForSeconds(1);


		CountDown.SetActive(false);
		CountDown.GetComponent<Text>().text = "2";
		GetReady.Play();
		CountDown.SetActive(true);
		yield return new WaitForSeconds(1);
        StartEngine.Play();


       
		CountDown.SetActive(false);
		CountDown.GetComponent<Text>().text = "1";
		GetReady.Play();
		CountDown.SetActive(true);
        yield return new WaitForSeconds(1);


		CountDown.SetActive(false);
		CountDown.GetComponent<Text>().text = "Go";
		GoAudio.Play();
        CarDefault.Play();
        LapTimer.SetActive(true);
		//Minimap.SetActive(true);

		CarControls.SetActive(true);
	}



}
