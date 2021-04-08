using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePoints : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;
    public static void Scoreplus1()
    {
        score++;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score "+score.ToString();
    }
}
