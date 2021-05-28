using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishedGameScript : MonoBehaviour
{
    public void LoadMenu()
    {
        Debug.Log("Loads Menu");
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
