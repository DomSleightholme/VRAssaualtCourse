using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    [Header("Timer")]
    private float timer;   
    public int minutes;
    public int seconds;
    public bool timeRunning = false;

    [Header("UI")]
    public Text minutesUI;
    public Text secondsUI;
    string minUI;
    string secUI;

    private void Update()
    {
        if(timeRunning == true)
        {
            timer += Time.deltaTime;
        }

        TimerOn();
        TimerUI();
    }

    void TimerOn()
    {
        minUI = Mathf.Floor(timer / 60).ToString("00");
        secUI = Mathf.RoundToInt(timer % 60).ToString("00");

        minutes = int.Parse(minUI);
        seconds = int.Parse(secUI);
    }

    void TimerUI()
    {
        minutesUI.text = minUI.ToString();
        secondsUI.text = secUI.ToString();
    }
}
