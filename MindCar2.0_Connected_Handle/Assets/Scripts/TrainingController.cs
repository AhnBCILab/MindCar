using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrainingController : MonoBehaviour
{
    UIVA_Client theClient;
    public GameObject upperText;
    public GameObject CountDown;
    public static int mode;

    void Start()
    {
        StartCoroutine(CountStart());
    }

    void TurnOff()
    {
        upperText.SetActive(false);
    }

    IEnumerator CountStart()
    { 
        
        Invoke("TurnOff", 0.01f);
        yield return new WaitForSeconds(0.01f);

        yield return new WaitForSeconds(0.01f);
        CountDown.SetActive(true);

        for (int i = 0; i > 0; i--) // i = time
        {
            yield return new WaitForSeconds(0.01f);
            CountDown.GetComponent<Text>().text = i.ToString();
        }

        if (mode == 0)
            SceneManager.LoadScene("default"); // cooperation
        else if (mode == 1)
            SceneManager.LoadScene("autoDefault"); // single player, auto defaults
        else
            SceneManager.LoadScene("competition"); // competition

    }
}