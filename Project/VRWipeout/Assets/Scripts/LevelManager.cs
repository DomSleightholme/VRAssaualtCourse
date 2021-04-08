using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public void StartLevel()
    {
       // ConinuousMovement movement = FindObjectOfType<ConinuousMovement>();
        LevelTimer timer = FindObjectOfType<LevelTimer>();
        timer.timeRunning = true;
        //movement.enabled = true;
    }

    public void PausedGame()
    {
        //ConinuousMovement movement = FindObjectOfType<ConinuousMovement>();
        //movement.enabled = false;
    }

    public void LevelDeath()
    {

    }

    public void LevelComplete()
    {

    }
}
