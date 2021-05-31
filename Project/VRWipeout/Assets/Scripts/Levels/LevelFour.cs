using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFour : MonoBehaviour
{
    public int Minutes;
    public int Seconds;
    public int RespawnAmount;
    public int TokenCollection;

    public bool Challenge1Compeleted;
    public bool Challenge2Compeleted;
    public bool Challenge3Compeleted;

    private void Update()
    {
        CheckChallenges();
    }

    public void CheckChallenges()
    {
        if(TokenCollection > 0)
        {
            Challenge1Compeleted = true;
        }
        if(Minutes < 3)
        {
            if(Seconds < 31)
            {
                Challenge2Compeleted = true;
            }         
        }
        if(RespawnAmount == 0)
        {
            Challenge3Compeleted = true;
        }
    }
}
