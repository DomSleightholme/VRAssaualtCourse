using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOne : MonoBehaviour
{
    public int Minutes;
    public int Seconds;
    public int RespawnAmount;

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
        if(Minutes < 3)
        {
            if(Seconds < 16)
            {
                Challenge1Compeleted = true;
            }        
        }
        else
        {
            Challenge1Compeleted = false;
        }
        if (Minutes < 1)
        {
            Challenge2Compeleted = true;
        }
        else
        {
            Challenge2Compeleted = false;
        }
        if(RespawnAmount < 1)
        {
            Challenge3Compeleted = true;
        }
        else
        {
            Challenge3Compeleted = false;
        }
        
    }
}
