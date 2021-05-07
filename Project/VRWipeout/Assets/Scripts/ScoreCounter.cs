using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    [Header("Score Factors")]
    public float CompletionTimeMinutes;
    public float CompletionTimeSeconds;
    public float RespawnAmount;

    [Header("Challenges")]
    public bool Challenge1Complete;
    public bool Challenge2Complete;
    public bool Challenge3Complete;

    [Header("Result")]
    public float FinalResult;
    public bool ChallengeOneStar;
    public bool ChallengeTwoStar;
    public bool ChallengeThreeStar;


    public void LevelComplete()
    {
        if (Challenge1Complete)
        {
            FinalResult += 100;
            ChallengeOneStar = true;
        }
        if (Challenge2Complete)
        {
            FinalResult += 200;
            ChallengeTwoStar = true;
        }
        if (Challenge3Complete)
        {
            FinalResult += 300;
            ChallengeThreeStar = true;
        }

        var scores = FindObjectOfType<PlayerScores>();
        if(SceneManager.GetActiveScene().buildIndex == 3 && FinalResult > scores.Level1_OverallScore)
        {
            scores.Level1_OverallScore = (int)FinalResult;
        }
    }
}
