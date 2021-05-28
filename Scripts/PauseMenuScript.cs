using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public static bool IsPause = false;
    public GameObject PauseUI;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }
    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        IsPause = false;
    }

    public void Pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        IsPause = true;
    }

    public void LoadMenu()
    {
        ScoreController.counter = 0;
        ScoreController.counter_2 = 0;
        Debug.Log("Loads Menu");
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quits");
        Application.Quit();
    }

    
}
