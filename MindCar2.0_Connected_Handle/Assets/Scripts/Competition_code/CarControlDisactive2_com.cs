using UnityEngine;
using System.Collections;

public class CarControlDisactive2_com : MonoBehaviour
{

    public GameObject otherobj;//your other object public string scr;
    // your secound script name 
    void Start(){
        (
            otherobj.GetComponent("SportCar_2_Controller_com") as MonoBehaviour).enabled = false;
    }


}

