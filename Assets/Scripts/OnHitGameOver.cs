using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnHitGameOver : MonoBehaviour
{
    public GameObject obj;
    public Text highscore;
    //private HiScore his;
    //int score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit Detected !");
        // his.HighScore();
        if (ScorePoints.score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", ScorePoints.score);
            highscore.text = ScorePoints.score.ToString();
        }
        SceneManager.LoadScene("GameOver");
        //Kabooom
        //Game Over with score and ask play again
    }
}
