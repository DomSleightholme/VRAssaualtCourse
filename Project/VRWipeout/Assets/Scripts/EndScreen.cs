using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [Header("Transforms")]
    public GameObject Challenge1;
    public GameObject Challenge2;
    public GameObject Challenge3;
    public TMP_Text Minutes;
    public TMP_Text Seconds;

    private void Update()
    {
        //Check Challenges
        ScoresUI();
    }

    public void ScoresUI()
    {
        //Search what level is used:
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            var levelStats = FindObjectOfType<LevelOne>();

            Minutes.text = levelStats.Minutes.ToString();
            Seconds.text = levelStats.Seconds.ToString();

            if (levelStats.Challenge1Compeleted)
            {
                Challenge1.SetActive(true);
            }
            if (levelStats.Challenge2Compeleted)
            {
                Challenge2.SetActive(true);
            }
            if (levelStats.Challenge3Compeleted)
            {
                Challenge3.SetActive(true);
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            var levelStats = FindObjectOfType<LevelTwo>();

            Minutes.text = levelStats.Minutes.ToString();
            Seconds.text = levelStats.Seconds.ToString();

            if (levelStats.Challenge1Compeleted)
            {
                Challenge1.SetActive(true);
            }
            if (levelStats.Challenge2Compeleted)
            {
                Challenge2.SetActive(true);
            }
            if (levelStats.Challenge3Compeleted)
            {
                Challenge3.SetActive(true);
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            var levelStats = FindObjectOfType<LevelThree>();

            if(levelStats.Seconds < 10)
            {              
                Seconds.text =  "0" + levelStats.Seconds.ToString();
            }
            else
            {
                Seconds.text = levelStats.Seconds.ToString();
            }

            if(levelStats.Minutes < 10)
            {
                Minutes.text =  "0" + levelStats.Minutes.ToString();
            }
            else
            {
                Minutes.text = levelStats.Minutes.ToString();
            }

            if (levelStats.Challenge1Compeleted)
            {
                Challenge1.SetActive(true);
            }
            else
            {
                Challenge1.SetActive(false);
            }
            if (levelStats.Challenge2Compeleted)
            {
                Challenge2.SetActive(true);
            }
            else
            {
                Challenge2.SetActive(false);
            }
            if (levelStats.Challenge3Compeleted)
            {
                Challenge3.SetActive(true);
            }
            else
            {
                Challenge3.SetActive(false);
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            var levelStats = FindObjectOfType<LevelFour>();

            Minutes.text = levelStats.Minutes.ToString();
            Seconds.text = levelStats.Seconds.ToString();

            if (levelStats.Challenge1Compeleted)
            {
                Challenge1.SetActive(true);
            }
            if (levelStats.Challenge2Compeleted)
            {
                Challenge2.SetActive(true);
            }
            if (levelStats.Challenge3Compeleted)
            {
                Challenge3.SetActive(true);
            }
        }
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
