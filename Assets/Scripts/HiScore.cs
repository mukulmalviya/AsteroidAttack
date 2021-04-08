using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiScore : MonoBehaviour
{
    public Text highscore;

    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void HighScore()
    {
        if(ScorePoints.score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", ScorePoints.score);
            highscore.text = "Last HighScore "+ScorePoints.score.ToString();
        }
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        highscore.text = "0";
        PlayerPrefs.SetInt("HighScore", 0);
    }
}
