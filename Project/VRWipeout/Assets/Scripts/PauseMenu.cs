using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused;
    public GameObject Menu;

    void Awake()
    {
        Resume();
    }

    public void InputCheck()
    {
        //If paused when called, the game will resume but if the game is resumed when called, the game pauses
        if (isPaused == true)
        {
            Resume();
        }
        if(isPaused == false)
        {
            Paused();
        }
    }

    public void Paused()
    {
        isPaused = true;
        Menu.SetActive(true);    

        var levelManager = FindObjectOfType<LevelManager>();
        levelManager.PausedGame();
    }
    public void Resume()
    {
        isPaused = false;
        Menu.SetActive(false);

        var levelManager = FindObjectOfType<LevelManager>();
        levelManager.LevelCountdown.SetTrigger("Start");
    }
}
