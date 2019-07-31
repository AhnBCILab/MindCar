using UnityEngine;
using System.Collections;

public class CarControlActive : MonoBehaviour
{

    public GameObject otherobj;//your other object public string scr;
    // your secound script name 
    void Start()
    {
        (
            otherobj.GetComponent("SportCar_1_Controller") as MonoBehaviour).enabled = true;
    }


}

