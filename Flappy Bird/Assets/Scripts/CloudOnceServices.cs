using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CloudOnce;

public class CloudOnceServices : MonoBehaviour
{
    public static CloudOnceServices instance;

    void Awake()
    {
        TestSingleton();
    }

    void TestSingleton()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SubmitScoreToLeaderboard(int score)
    {
        Leaderboards.highScore.SubmitScore(score);
    }

    public void AwardHighScore25()
    {
        if(Achievements.HighScore25.IsUnlocked){return;}
        Achievements.HighScore25.Unlock();
    }

    public void AwardHighScore50()
    {
        if(Achievements.HighScore50.IsUnlocked){return;}
        Achievements.HighScore50.Unlock();
    }

    public void AwardHighScore100()
    {
        if(Achievements.HighScore100.IsUnlocked){return;}
        Achievements.HighScore100.Unlock();
    }
}
