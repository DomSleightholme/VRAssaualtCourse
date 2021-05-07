using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CourseScoresUI : MonoBehaviour
{
    [Header("Level_1")]
    public float Level1_Minutes;
    public float Level1_Seconds;

    public TMP_Text Level1_MinutesUI;
    public TMP_Text Level1_SecondsUI;
    public GameObject Level1_Challenge1;
    public GameObject Level1_Challenge2;
    public GameObject Level1_Challenge3;

    [Header("Level_2")]
    public float Level2_Minutes;
    public float Level2_Seconds;

    public TMP_Text Level2_MinutesUI;
    public TMP_Text Level2_SecondsUI;
    public GameObject Level2_Challenge1;
    public GameObject Level2_Challenge2;
    public GameObject Level2_Challenge3;

    [Header("Level_3")]
    public float Level3_Minutes;
    public float Level3_Seconds;

    public TMP_Text Level3_MinutesUI;
    public TMP_Text Level3_SecondsUI;
    public GameObject Level3_Challenge1;
    public GameObject Level3_Challenge2;
    public GameObject Level3_Challenge3;

    [Header("Level_4")]
    public float Level4_Minutes;
    public float Level4_Seconds;

    public TMP_Text Level4_MinutesUI;
    public TMP_Text Level4_SecondsUI;
    public GameObject Level4_Challenge1;
    public GameObject Level4_Challenge2;
    public GameObject Level4_Challenge3;

    private PlayerScores scores;
    private void Start()
    {
        scores = FindObjectOfType<PlayerScores>();
    }

    public void Level1Stats()
    {
        //Handling the minutes and seconds of the level
        int minsText = (int)Level1_Minutes;
        if (minsText < 10)
        {
            Level1_MinutesUI.text = "0" + minsText.ToString();
        }
        else
        {
            Level1_MinutesUI.text = minsText.ToString();
        }

        int secsText = (int)Level1_Seconds;
        if (secsText < 10)
        {
            Level1_SecondsUI.text = "0" + secsText.ToString();
        }
        else
        {
            Level1_SecondsUI.text = secsText.ToString();
        }

        //Handling the Challenge Icons
        if (scores.Level1_Challenge1)
        {
            Level1_Challenge1.SetActive(true);
        }
        if (scores.Level1_Challenge2)
        {
            Level1_Challenge2.SetActive(true);
        }
        if (scores.Level1_Challenge3)
        {
            Level1_Challenge3.SetActive(true);
        }
    }

    public void Level2Stats()
    {
        //Handling the minutes and seconds of the level
        int minsText = (int)Level2_Minutes;
        if (minsText < 10)
        {
            Level2_MinutesUI.text = "0" + minsText.ToString();
        }
        else
        {
            Level2_MinutesUI.text = minsText.ToString();
        }

        int secsText = (int)Level2_Seconds;
        if (secsText < 10)
        {
            Level2_SecondsUI.text = "0" + secsText.ToString();
        }
        else
        {
            Level2_SecondsUI.text = secsText.ToString();
        }

        //Handling the Challenge Icons
        if (scores.Level2_Challenge1)
        {
            Level2_Challenge1.SetActive(true);
        }
        if (scores.Level2_Challenge2)
        {
            Level2_Challenge2.SetActive(true);
        }
        if (scores.Level2_Challenge3)
        {
            Level2_Challenge3.SetActive(true);
        }
    }

    public void Level3Stats()
    {
        //Handling the minutes and seconds of the level
        int minsText = (int)Level3_Minutes;
        if (minsText < 10)
        {
            Level3_MinutesUI.text = "0" + minsText.ToString();
        }
        else
        {
            Level3_MinutesUI.text = minsText.ToString();
        }

        int secsText = (int)Level3_Seconds;
        if (secsText < 10)
        {
            Level3_SecondsUI.text = "0" + secsText.ToString();
        }
        else
        {
            Level3_SecondsUI.text = secsText.ToString();
        }

        //Handling the Challenge Icons
        if (scores.Level3_Challenge1)
        {
            Level3_Challenge1.SetActive(true);
        }
        if (scores.Level3_Challenge2)
        {
            Level3_Challenge2.SetActive(true);
        }
        if (scores.Level3_Challenge3)
        {
            Level3_Challenge3.SetActive(true);
        }
    }

    public void Level4Stats()
    {
        //Handling the minutes and seconds of the level
        int minsText = (int)Level4_Minutes;
        if (minsText < 10)
        {
            Level4_MinutesUI.text = "0" + minsText.ToString();
        }
        else
        {
            Level4_MinutesUI.text = minsText.ToString();
        }

        int secsText = (int)Level4_Seconds;
        if (secsText < 10)
        {
            Level4_SecondsUI.text = "0" + secsText.ToString();
        }
        else
        {
            Level4_SecondsUI.text = secsText.ToString();
        }

        //Handling the Challenge Icons
        if (scores.Level4_Challenge1)
        {
            Level4_Challenge1.SetActive(true);
        }
        if (scores.Level4_Challenge2)
        {
            Level4_Challenge2.SetActive(true);
        }
        if (scores.Level4_Challenge3)
        {
            Level4_Challenge3.SetActive(true);
        }
    }
}
