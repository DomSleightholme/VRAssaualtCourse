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
        LevelTimer timer = FindObjectOfType<LevelTimer>();
        timer.timeRunning = true;
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
}
