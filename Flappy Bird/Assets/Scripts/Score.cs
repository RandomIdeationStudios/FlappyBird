using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int GameScore = 0;
    public Text scoreText;
    public Text GameOverScoreTest;

    void Start()
    {
        GameScore = 0;
    }

    void Update()
    {
        if(GameScore == 25)
        {
            CloudOnceServices.instance.AwardHighScore25();
        }

        if(GameScore == 50)
        {
            CloudOnceServices.instance.AwardHighScore50();
        }

        if(GameScore == 100)
        {
            CloudOnceServices.instance.AwardHighScore100();
        }

        scoreText.text = GameScore.ToString();
        GameOverScoreTest.text = "Score : " + GameScore.ToString();
    }
}
