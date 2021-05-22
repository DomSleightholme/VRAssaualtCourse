using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    [Header("Score Factors")]
    public int FinalResultMinutes;
    public int FinalResultSeconds;
    public float RespawnAmount;

    [Header("Challenges")]
    public bool Challenge1Complete;
    public bool Challenge2Complete;
    public bool Challenge3Complete;

    private PlayerScores scores;
    private void Start()
    {
        scores = FindObjectOfType<PlayerScores>();
    }

    public void LevelComplete()
    {
        //Check times and scores
        CheckTimes();
        CheckChallenges();
    }

    private void CheckTimes()
    {
        //Gets the scene index to check which level the player is on
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(sceneIndex == 3 && FinalResultMinutes < scores.Level1_Minutes)
        {
            scores.Level1_Minutes = FinalResultMinutes;
            scores.Level1_Seconds = FinalResultSeconds;
        }
        if (sceneIndex == 4 && FinalResultMinutes < scores.Level2_Minutes)
        {
            scores.Level2_Minutes = FinalResultMinutes;
            scores.Level2_Seconds = FinalResultSeconds;
        }
        if (sceneIndex == 5 && FinalResultMinutes < scores.Level3_Minutes)
        {
            scores.Level3_Minutes = FinalResultMinutes;
            scores.Level3_Seconds = FinalResultSeconds;
        }
        if (sceneIndex == 6 && FinalResultMinutes < scores.Level4_Minutes)
        {
            scores.Level4_Minutes = FinalResultMinutes;
            scores.Level4_Seconds = FinalResultSeconds;
        }
    }

    private void CheckChallenges()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;

        //Level 1
        if(sceneIndex == 3 && Challenge1Complete)
        {
            scores.Level1_Challenge1 = true;
        }
        if (sceneIndex == 3 && Challenge2Complete)
        {
            scores.Level1_Challenge2 = true;
        }
        if (sceneIndex == 3 && Challenge3Complete)
        {
            scores.Level1_Challenge3 = true;
        }

        //Level 2
        if (sceneIndex == 4 && Challenge1Complete)
        {
            scores.Level2_Challenge1 = true;
        }
        if (sceneIndex == 4 && Challenge2Complete)
        {
            scores.Level2_Challenge2 = true;
        }
        if (sceneIndex == 4 && Challenge3Complete)
        {
            scores.Level2_Challenge3 = true;
        }

        //Level 3
        if (sceneIndex == 5 && Challenge1Complete)
        {
            scores.Level3_Challenge1 = true;
        }
        if (sceneIndex == 5 && Challenge2Complete)
        {
            scores.Level3_Challenge2 = true;
        }
        if (sceneIndex == 5 && Challenge3Complete)
        {
            scores.Level3_Challenge3 = true;
        }

        //Level 4
        if (sceneIndex == 6 && Challenge1Complete)
        {
            scores.Level4_Challenge1 = true;
        }
        if (sceneIndex == 6 && Challenge2Complete)
        {
            scores.Level4_Challenge2 = true;
        }
        if (sceneIndex == 6 && Challenge3Complete)
        {
            scores.Level4_Challenge3 = true;
        }
    }
}
