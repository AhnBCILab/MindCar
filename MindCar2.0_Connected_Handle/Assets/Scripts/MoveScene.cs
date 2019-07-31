using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class MoveScene : MonoBehaviour
{
    void Start ()
    {
        
    }
    
    void Update ()
    {
        
    }
    public void QuitGame()
    {
         Application.Quit();
    }

    public void ChangeGameScene_0()
    {
        SceneManager.LoadScene("0_StartView");
    }

    public void ChangeGameScene_1()
    {
        SceneManager.LoadScene("1_Mode");
    }

    public void ChangeGameScene_2_1()
    {
		SceneManager.LoadScene("2_1_Individual");
    }

    public void ChangeGameScene_2_2()
    {
        SceneManager.LoadScene("2_2_Competition");
    }

    public void ChangeGameScene_3_1()
    {
        SceneManager.LoadScene("3_1_Training");
    }
	
	public void ChangeGameScene_4_1()
    {
        SceneManager.LoadScene("default");
    }

	public void ChangeGameScene_4_2()
    {
        SceneManager.LoadScene("autoDefault");
    }
		public void ChangeGameScene_4_3()
    {
        SceneManager.LoadScene("competition");
    }

}