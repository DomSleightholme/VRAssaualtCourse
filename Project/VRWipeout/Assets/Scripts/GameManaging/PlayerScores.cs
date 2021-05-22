using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScores : MonoBehaviour
{
    [Header("Level 1")]
    public int Level1_Minutes;
    public int Level1_Seconds;
    public bool Level1_Challenge1;
    public bool Level1_Challenge2;
    public bool Level1_Challenge3;
    public int Level1_OverallScore;

    [Header("Level 2")]
    public int Level2_Minutes;
    public int Level2_Seconds;
    public bool Level2_Challenge1;
    public bool Level2_Challenge2;
    public bool Level2_Challenge3;

    [Header("Level 3")]
    public int Level3_Minutes;
    public int Level3_Seconds;
    public bool Level3_Challenge1;
    public bool Level3_Challenge2;
    public bool Level3_Challenge3;

    [Header("Level 4")]
    public int Level4_Minutes;
    public int Level4_Seconds;
    public bool Level4_Challenge1;
    public bool Level4_Challenge2;
    public bool Level4_Challenge3;

    private static PlayerScores playerScores;
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (playerScores == null)
        {
            playerScores = this;
        }
        else
        {
            DestroyObject(this.gameObject);
        }
    }
}
