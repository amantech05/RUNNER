using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public Text FinalScoreText;
    public PlayerScript playerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int myscore = 0;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE :- " + myscore.ToString();
        FinalScoreText.text = "SCORE :- " + myscore.ToString();
    }

    public void AddScore(int score)
    {
        myscore = myscore + score;

        /*if (myscore % 10 == 0)
        {
            player.IncreaseSpeed();
        }*/

    }
}
