using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceUIManager : MonoBehaviour {

    public GameObject Car1p;
    public GameObject Car2p;

    public GameObject MarkUI1p;
    public GameObject MarkUI2p;

    //private int TotalUIDistance = 576;
    private int TotalUIDistance = 520;
    private int UIDistancePartition;
    private int StartUILocation = 7;
    private int differance1p = -50;
    private int differance2p = -40;
    private int defaultX = 483;
     // Use this for initialization
     void Start () {
        UIDistancePartition = TotalUIDistance / 6;


    }
	
	// Update is called once per frame
	void Update () {

        // var turn1p = GameObject.Find("TurnManager").GetComponent<TurnManager_com>();

        //player1
        if (TurnManager_com.Turncount == 0)
        {
            if (Car1p.transform.position.x > 570) {
                MarkUI1p.transform.position = (new Vector3(defaultX + differance1p, StartUILocation + 
                                                (-(((Car1p.transform.position.z) - 1400)) / 1200) * UIDistancePartition, 0));
            }
            else
            {

                MarkUI1p.transform.position = (new Vector3(defaultX + differance1p, StartUILocation + 
                                                (((Car1p.transform.position.z) - 200) / 1200) * UIDistancePartition + UIDistancePartition, 0));
            }
        }

        else if (TurnManager_com.Turncount == 1)
        {
            if (Car1p.transform.position.x > 570)
            {
                MarkUI1p.transform.position = (new Vector3(defaultX + differance1p, StartUILocation + 
                                                 (-(((Car1p.transform.position.z) - 1400)) / 1200) * UIDistancePartition + UIDistancePartition * 2, 0));
            }
            else
            {
                MarkUI1p.transform.position = (new Vector3(defaultX + differance1p, StartUILocation + 
                                                (((Car1p.transform.position.z) - 200) / 1200) * UIDistancePartition + UIDistancePartition * 3, 0));
            }
        }

        else if (TurnManager_com.Turncount == 2)
        {
            if (Car1p.transform.position.x > 570)
            {
                MarkUI1p.transform.position = (new Vector3(defaultX + differance1p, StartUILocation +
                                                (-(((Car1p.transform.position.z) - 1400)) / 1200) * UIDistancePartition + UIDistancePartition * 4, 0));
            }
            else
            {
                MarkUI1p.transform.position = (new Vector3(defaultX + differance1p, StartUILocation + 
                                                (((Car1p.transform.position.z) - 200) / 1200) * UIDistancePartition + UIDistancePartition * 5, 0));
            }
        }
        else
        {
            MarkUI1p.transform.position = (new Vector3(defaultX + differance1p, StartUILocation + TotalUIDistance, 0));
        }



        //player2
        if (TurnManager2_com.Turncount == 0)
        {
            if (Car2p.transform.position.x > 570)
            {
                MarkUI2p.transform.position = (new Vector3(defaultX + differance2p, StartUILocation +
                                                (-(((Car2p.transform.position.z) - 1400)) / 1200) * UIDistancePartition, 0));
            }
            else
            {
                MarkUI2p.transform.position = (new Vector3(defaultX + differance2p, StartUILocation +
                                                (((Car2p.transform.position.z) - 200) / 1200) * UIDistancePartition + UIDistancePartition, 0));
            }
        }
        else if (TurnManager2_com.Turncount == 1)
        {
            if (Car2p.transform.position.x > 570)
            {
                MarkUI2p.transform.position = (new Vector3(defaultX + differance2p, StartUILocation +
                                                (-(((Car2p.transform.position.z) - 1400)) / 1200) * UIDistancePartition + UIDistancePartition * 2, 0));
            }
            else
            {
                MarkUI2p.transform.position = (new Vector3(defaultX + differance2p, StartUILocation +
                                                (((Car2p.transform.position.z) - 200) / 1200) * UIDistancePartition + UIDistancePartition * 3, 0));
            }
        }
        else if (TurnManager2_com.Turncount == 2)
        {
            if (Car2p.transform.position.x > 590)
            {
                MarkUI2p.transform.position = (new Vector3(defaultX + differance2p, StartUILocation +
                                                (-(((Car2p.transform.position.z) - 1400)) / 1200) * UIDistancePartition + UIDistancePartition * 4, 0));
            }
            else
            {
                MarkUI2p.transform.position = (new Vector3(defaultX + differance2p, StartUILocation  + 
                                                (((Car2p.transform.position.z) - 200) / 1200) * UIDistancePartition + UIDistancePartition * 5, 0));
            }
        }
        else
        {
            MarkUI2p.transform.position = (new Vector3(defaultX + differance2p, StartUILocation + TotalUIDistance, 0));
        }

    }
}
