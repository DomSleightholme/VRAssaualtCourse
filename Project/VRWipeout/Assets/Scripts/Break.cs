using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    [Header("Timer Limit")]
    public float TimeLimit;

    [Header("Timer")]
    public float minTimer;
    public float secTimer;
    public bool timerOn;

    [Header("Transforms")]
    public GameObject UI;

    private static Break @break;
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (@break == null)
        {
            @break = this;
        }
        else
        {
            DestroyObject(this.gameObject);
        }

        minTimer = TimeLimit;
        UI.SetActive(false);
    }

    private void Update()
    {
        if (timerOn)
        {
           if(minTimer == 0.0f)
           {
                TimerEnd();
           }
            else
            {
                if (secTimer > 0)
                {
                    secTimer -= Time.deltaTime;
                }
                else
                {
                    secTimer = 60;
                    minTimer--;
                }
            }
        }
    }

    public void TimerEnd()
    {
        UI.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseUi()
    {
        UI.SetActive(false);
        Time.timeScale = 1;
    }
}
