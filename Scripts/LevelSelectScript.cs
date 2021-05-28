using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelectScript : MonoBehaviour
{
    public void Level_1()
    {
        ScoreController.counter = 0;
        ScoreController.counter_2 = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back_To_StartScreen()
    {
        SceneManager.LoadScene(0);
    }

}
