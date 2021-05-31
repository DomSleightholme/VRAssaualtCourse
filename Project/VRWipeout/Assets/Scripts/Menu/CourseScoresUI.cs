using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CourseScoresUI : MonoBehaviour
{
    [Header("Level_1")]
    public int Level1_Minutes;
    public int Level1_Seconds;

    public TMP_Text Level1_MinutesUI;
    public TMP_Text Level1_SecondsUI;
    public GameObject Level1_Challenge1;
    public GameObject Level1_Challenge2;
    public GameObject Level1_Challenge3;

    //Private Variables
    private int Level1Challenge1;
    private int Level1Challenge2;
    private int Level1Challenge3;

    [Header("Level_2")]
    public int Level2_Minutes;
    public int Level2_Seconds;

    public TMP_Text Level2_MinutesUI;
    public TMP_Text Level2_SecondsUI;
    public GameObject Level2_Challenge1;
    public GameObject Level2_Challenge2;
    public GameObject Level2_Challenge3;

    //Private Variables
    private int Level2Challenge1;
    private int Level2Challenge2;
    private int Level2Challenge3;

    [Header("Level_3")]
    public int Level3_Minutes;
    public int Level3_Seconds;

    public TMP_Text Level3_MinutesUI;
    public TMP_Text Level3_SecondsUI;
    public GameObject Level3_Challenge1;
    public GameObject Level3_Challenge2;
    public GameObject Level3_Challenge3;

    //Private Variables
    private int Level3Challenge1;
    private int Level3Challenge2;
    private int Level3Challenge3;

    [Header("Level_4")]
    public int Level4_Minutes;
    public int Level4_Seconds;

    public TMP_Text Level4_MinutesUI;
    public TMP_Text Level4_SecondsUI;
    public GameObject Level4_Challenge1;
    public GameObject Level4_Challenge2;
    public GameObject Level4_Challenge3;

    //Private Variables
    private int Level4Challenge1;
    private int Level4Challenge2;
    private int Level4Challenge3;

    void getData()
    {
        //Get the times of each level:
        Level1_Minutes = PlayerPrefs.GetInt("Level1Minutes");
        Level1_Seconds = PlayerPrefs.GetInt("Level1Seconds");
        Level2_Minutes = PlayerPrefs.GetInt("Level2Minutes");
        Level2_Seconds = PlayerPrefs.GetInt("Level2Seconds");
        Level3_Minutes = PlayerPrefs.GetInt("Level3Minutes");
        Level3_Seconds = PlayerPrefs.GetInt("Level3Seconds"); 
        Level4_Seconds = PlayerPrefs.GetInt("Level4Minutes");
        Level4_Minutes = PlayerPrefs.GetInt("Level4Seconds");

        //Get challenges
        Level1Challenge1 = PlayerPrefs.GetInt("Level1Challenge1");
        Level1Challenge2 = PlayerPrefs.GetInt("Level1Challenge2");
        Level1Challenge3 = PlayerPrefs.GetInt("Level1Challenge3");

        Level2Challenge1 = PlayerPrefs.GetInt("Level2Challenge1");
        Level2Challenge2 = PlayerPrefs.GetInt("Level2Challenge2");
        Level2Challenge3 = PlayerPrefs.GetInt("Level2Challenge3");

        Level3Challenge1 = PlayerPrefs.GetInt("Level3Challenge1");
        Level3Challenge2 = PlayerPrefs.GetInt("Level3Challenge2");
        Level3Challenge3 = PlayerPrefs.GetInt("Level3Challenge3");

        Level4Challenge1 = PlayerPrefs.GetInt("Level4Challenge1");
        Level4Challenge2 = PlayerPrefs.GetInt("Level4Challenge2");
        Level4Challenge3 = PlayerPrefs.GetInt("Level4Challenge3");
    }

    private void Update()
    {
        getData();

        Level1Stats();
        Level2Stats();
        Level3Stats();
        Level4Stats();
    }

    public void Level1Stats()
    {
        //Handling the minutes and seconds of the level
        int minsText = Level1_Minutes;
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
        if (Level1Challenge1 == 1)
        {
            Level1_Challenge1.SetActive(true);
        }
        else
        {
            Level1_Challenge1.SetActive(false);
        }
        if (Level1Challenge2 == 1)
        {
            Level1_Challenge2.SetActive(true);
        }
        else
        {
            Level1_Challenge2.SetActive(false);
        }
        if (Level1Challenge3 == 1)
        {
            Level1_Challenge3.SetActive(true);
        }
        else
        {
            Level1_Challenge3.SetActive(false);
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
        if (Level2Challenge1 == 1)
        {
            Level2_Challenge1.SetActive(true);
        }
        else
        {
            Level2_Challenge1.SetActive(false);
        }
        if (Level2Challenge2 == 1)
        {
            Level2_Challenge2.SetActive(true);
        }
        else
        {
            Level2_Challenge2.SetActive(false);
        }
        if (Level2Challenge3 == 1)
        {
            Level2_Challenge3.SetActive(true);
        }
        else
        {
            Level2_Challenge3.SetActive(false);
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
        if (Level3Challenge1 == 1)
        {
            Level3_Challenge1.SetActive(true);
        }
        else
        {
            Level3_Challenge1.SetActive(false);
        }
        if (Level3Challenge2 == 1)
        {
            Level3_Challenge2.SetActive(true);
        }
        else
        {
            Level3_Challenge2.SetActive(false);
        }
        if (Level3Challenge3 == 1)
        {
            Level3_Challenge3.SetActive(true);
        }
        else
        {
            Level3_Challenge3.SetActive(false);
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
        if (Level4Challenge1 == 1)
        {
            Level4_Challenge1.SetActive(true);
        }
        else
        {
            Level4_Challenge1.SetActive(false);
        }
        if (Level4Challenge2 == 1)
        {
            Level4_Challenge2.SetActive(true);
        }
        else
        {
            Level4_Challenge2.SetActive(false);
        }
        if (Level4Challenge3 == 1)
        {
            Level4_Challenge3.SetActive(true);
        }
        else
        {
            Level4_Challenge3.SetActive(false);
        }
    }
}
