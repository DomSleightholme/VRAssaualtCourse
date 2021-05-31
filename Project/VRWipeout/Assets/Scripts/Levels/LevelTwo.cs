using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTwo : MonoBehaviour
{
    public int Minutes;
    public int Seconds;

    public bool Challenge1Compeleted;
    public bool Challenge2Compeleted;
    public bool Challenge3Compeleted;

    private void Update()
    {
        CheckChallenges();
    }

    public void CheckChallenges()
    {
        if(Minutes == 1 || Minutes > 1)
        {
            Challenge1Compeleted = true;
        }
        if (Minutes == 3 || Minutes > 3)
        {
            Challenge2Compeleted = true;
        }
        if (Minutes == 6 || Minutes > 6)
        {
            Challenge3Compeleted = true;
        }
    }
}
