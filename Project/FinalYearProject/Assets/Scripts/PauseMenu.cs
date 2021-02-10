using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused;
    public GameObject Menu;
    private VRControllers inputActions;

    void Awake()
    {
        inputActions = new VRControllers();
        Resume();
    }

    private void Start()
    {
        //using Unitys new input system to track pause being used on keyboard or gamepad
        inputActions.Player.Pause.performed += _ => InputCheck();
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
