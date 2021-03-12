using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour
{
    [Header("Distance")]
    public float DistanceLeft;
    public float DistanceOverall;
    public GameObject Player;

    [Header("UI")]
    public Slider DistanceTracker;

    private void Start()
    {
        DistanceOverall = (Player.transform.position - transform.position).magnitude;

        DistanceTracker.maxValue = DistanceOverall;

        Player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Update()
    {
        Tracker();       
    }


    public void Tracker()
    {
        DistanceLeft = (Player.transform.position - transform.position).magnitude;

        DistanceTracker.value = DistanceLeft;
    }

}
