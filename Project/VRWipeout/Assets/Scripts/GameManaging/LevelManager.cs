using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float startDelay;
    public bool LevelRunning;
    public Animator LevelCountdown;

    private void Awake()
    {
        if(SceneManager.GetActiveScene().buildIndex > 2)
        {
            LevelCountdown.SetTrigger("Start");
        }
    }

    public void StartLevel()
    {
        LevelRunning = true;
    }

    public void PausedGame()
    {
        LevelTimer timer = FindObjectOfType<LevelTimer>();
        timer.timeRunning = false;
        LevelRunning = false;
    }
    public void LevelComplete()
    {
        var scores = FindObjectOfType<ScoreCounter>();
        scores.LevelComplete();
    }

    public void endGame()
    {
        Application.Quit();
    }

    public void goHome()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
