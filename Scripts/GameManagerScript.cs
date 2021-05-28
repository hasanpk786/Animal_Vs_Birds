using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    bool LevelEnd = false;
    public GameObject LevelFailedUI;
    public GameObject LevelCompleteUI;
    bool LevelWon = false;
    public int Num_Apples = 5;

    private void Update()
    {
        if (ScoreController.counter + ScoreController.counter_2 == Num_Apples)
        {
            if (ScoreController.counter > ScoreController.counter_2)
            {
                Invoke("LevelFailed", 0.25f);
            }

            else
            {
                Invoke("CompleteLevel", 0.25f);
            }
        }
    }

    public void CompleteLevel()
    {
        if (LevelEnd == false)
        {
            LevelEnd = true;
            LevelCompleteUI.SetActive(true);
            Time.timeScale = 0f;
        }

    }

    public void levelSelectScreen()
    {
        Time.timeScale = 1f;
        LevelEnd = false;
        ScoreController.counter = 0;
        ScoreController.counter_2 = 0;
        SceneManager.LoadScene(1);
    }

    public void NextLevel()
    {
        //Time.timeScale = 1f;
        LevelEnd = false;
        ScoreController.counter = 0;
        ScoreController.counter_2 = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Debug.Log("NEXT LEVEL");
        Time.timeScale = 1f;
    }

    public void LevelFailed()
    {
            
        if (LevelEnd == false)
        {
            LevelEnd = true;    
            LevelFailedUI.SetActive(true);
            Time.timeScale = 0f;
        }
        

    }

    public void Restart()
    {
        //restarts current level
        Time.timeScale = 1f;
        LevelEnd = false;
        ScoreController.counter = 0;
        ScoreController.counter_2 = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
