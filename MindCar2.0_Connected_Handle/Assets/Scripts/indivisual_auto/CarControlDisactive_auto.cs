using UnityEngine;
using System.Collections;

public class CarControlDisactive_auto : MonoBehaviour
{

    public GameObject otherobj;//your other object public string scr;
    // your secound script name 
    void Start(){
        (
            otherobj.GetComponent("SportCar_1_Controller_auto") as MonoBehaviour).enabled = false;
    }


}

