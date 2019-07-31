using UnityEngine;
using System.Collections;

public class CarControlActive2_com : MonoBehaviour
{

    public GameObject otherobj;//your other object 
    void Start () {(
        otherobj.GetComponent("SportCar_2_Controller_com") as MonoBehaviour).enabled = true;
    }


 }

