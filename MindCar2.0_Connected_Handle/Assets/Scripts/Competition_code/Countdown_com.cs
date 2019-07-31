using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Countdown_com : MonoBehaviour {

	public GameObject CountDown;
	public GameObject CountDown2;
	public AudioSource GetReady;
	public AudioSource GoAudio;
	public GameObject LapTimer;
	public GameObject LapTimer2;
	public GameObject CarControls;
    public GameObject CarControls2; 
	public GameObject Minimap;


    

	void Start()
	{
        
		StartCoroutine(CountStart());

	}

   
	IEnumerator CountStart()
	{

		yield return new WaitForSeconds(0.5f);
		CountDown.GetComponent<Text>().text = "3";
		CountDown2.GetComponent<Text>().text = "3";
		GetReady.Play();
		CountDown.SetActive(true);
		CountDown2.SetActive(true);
		yield return new WaitForSeconds(1);


		CountDown.SetActive(false);
		CountDown2.SetActive(false);
		CountDown.GetComponent<Text>().text = "2";
		CountDown2.GetComponent<Text>().text = "2";
		GetReady.Play();
		CountDown.SetActive(true);
		CountDown2.SetActive(true);
		yield return new WaitForSeconds(1);


		CountDown.SetActive(false);
		CountDown.GetComponent<Text>().text = "1";
		CountDown2.GetComponent<Text>().text = "1";
		GetReady.Play();
		CountDown.SetActive(true);
		CountDown2.SetActive(true);
		yield return new WaitForSeconds(1);


		CountDown.SetActive(false);
		CountDown2.SetActive(false);
		CountDown.GetComponent<Text>().text = "Go";
		CountDown2.GetComponent<Text>().text = "Go";
		CountDown.SetActive(true);
		CountDown2.SetActive(true);
		GoAudio.Play();

		LapTimer.SetActive(true);
		LapTimer2.SetActive(true);
		CountDown.SetActive(false);
		CountDown2.SetActive(false);

		CarControls.SetActive(true);
        CarControls2.SetActive(true);
	}



}
