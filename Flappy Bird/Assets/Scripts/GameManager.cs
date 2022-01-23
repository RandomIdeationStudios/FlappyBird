using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverCanvas;
    public Text highScoreText;

    void Start()
    {
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        if(Score.GameScore > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", Score.GameScore);
            CloudOnceServices.instance.SubmitScoreToLeaderboard(Score.GameScore);
        }

        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("highscore");
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Replay()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
