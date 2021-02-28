using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused;
    public GameObject Menu;
    public float PauseCountdownTimer;
    public float tst = 0;
    private XRIDefaultInputActions inputActions;

    void Awake()
    {
        inputActions = new XRIDefaultInputActions();
        inputActions.XRILeftHand.Pause.performed += ctx => InputCheck();
       
        Resume();
    }

    public void InputCheck()
    {
        //If paused when called, the game will resume but if the game is resumed when called, the game pauses
        if (isPaused == true)
        {
            Resume();
        }
        else
        {
            Paused();
        }
    }

    void Paused()
    {
        isPaused = true;
        Menu.SetActive(true);
        Time.timeScale = 0;

        var levelManager = FindObjectOfType<LevelManager>();
        levelManager.PausedGame();
    }
    void Resume()
    {
        isPaused = false;
        Menu.SetActive(false);
        Time.timeScale = 1;

        var Countdown = FindObjectOfType<Countdown>();
        Countdown.StartCountdown();
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }
}
