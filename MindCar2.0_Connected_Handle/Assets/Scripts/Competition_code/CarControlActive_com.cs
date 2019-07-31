using UnityEngine;
using System.Collections;

public class CarControlActive_com : MonoBehaviour
{

    public GameObject otherobj;//your other object 
    void Start () {(
        otherobj.GetComponent("SportCar_1_Controller_com") as MonoBehaviour).enabled = true;
    }


 }

