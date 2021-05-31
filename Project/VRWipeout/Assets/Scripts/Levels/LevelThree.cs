﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelThree : MonoBehaviour
{
    public int Minutes;
    public int Seconds;
    public int RespawnAmount;
    public int TokenAmount;

    public bool Challenge1Compeleted;
    public bool Challenge2Compeleted;
    public bool Challenge3Compeleted;

    private void Update()
    {
        //Find time
        var levelTimer = FindObjectOfType<LevelTimer>();
        Minutes = levelTimer.minutes;
        Seconds = levelTimer.seconds;

        //Check challenges
        CheckChallenges();
    }

    public void CheckChallenges()
    {
        if(RespawnAmount == 0)
        {
            Challenge1Compeleted = true;
        }
        else
        {
            Challenge1Compeleted = false;
        }

        if(TokenAmount == 1)
        {
            Challenge2Compeleted = true;
        }

        if(Minutes < 3)
        {
            if(Seconds < 16)
            {
                Challenge3Compeleted = true;
            }       
        }
    }
}
