using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void Start()
    {
        FindObjectOfType<AudioManagerScript>().Play("StartMusic");
    }
    //Starts Game
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Quit Application
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
