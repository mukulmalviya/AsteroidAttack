using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("App Closed.");
    }

    public void StartGame()
    {
        ScorePoints.score = 0;
        SceneManager.LoadScene("game");
    }
}
