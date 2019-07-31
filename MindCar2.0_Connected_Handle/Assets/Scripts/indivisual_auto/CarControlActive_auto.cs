using UnityEngine;
using System.Collections;

public class CarControlActive_auto : MonoBehaviour
{

    public GameObject otherobj;//your other object 
    void Start () {(
        otherobj.GetComponent("SportCar_1_Controller_auto") as MonoBehaviour).enabled = true;
    }


 }

