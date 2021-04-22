using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [Header("Score Factors")]
    public float CompletionTime;
    public float RespawnAmount;
    public float LevelDifficulty;

    [Header("Challenges")]
    public bool Challenge1Complete;
    public bool Challenge2Complete;
    public bool Challenge3Complete;

    [Header("Result")]
    public float FinalResult;
    public bool GoldMedal;
    public bool SliverMedal;
    public bool BronzeMedal;

    private float GoldValue;
    private float SilverValue;
    private float BronzeValue;

    public void LevelComplete()
    {
        MedalValues();

        float finalScore;

        finalScore = RespawnAmount + LevelDifficulty * CompletionTime;

        if (Challenge1Complete)
        {
            finalScore += 100;
        }
        if (Challenge1Complete)
        {
            finalScore += 200;
        }
        if (Challenge1Complete)
        {
            finalScore += 300;
        }

        CalculateMedal(finalScore);
    }

    private void MedalValues()
    {
        GoldValue = RespawnAmount + LevelDifficulty * CompletionTime + 600;
        SilverValue = RespawnAmount + LevelDifficulty * CompletionTime + 300;
        BronzeValue = RespawnAmount + LevelDifficulty * CompletionTime;
    }

    public void CalculateMedal(float score)
    {
        if(score == GoldValue)
        {
            GoldMedal = true;
            SliverMedal = true;
            BronzeMedal = true;
        }
        else if(score == SilverValue)
        {
            GoldMedal = false;
            SliverMedal = true;
            BronzeMedal = true;
        }
        else
        {
            GoldMedal = false;
            SliverMedal = false;
            BronzeMedal = true;
        }
    }
}
