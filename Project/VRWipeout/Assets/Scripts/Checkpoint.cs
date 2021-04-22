using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour
{
    [Header("Distance")]
    public int distanceLeft;
    public int distanceOverall;
    private float DistanceLeft;
    private float DistanceOverall;
    public GameObject Player;

    private void Start()
    {
        DistanceOverall = (Player.transform.position - transform.position).magnitude;
        distanceOverall = Mathf.FloorToInt(DistanceOverall);

        Player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Update()
    {
        Tracker();       
    }


    public void Tracker()
    {
        DistanceLeft = (Player.transform.position - transform.position).magnitude;

        distanceLeft = Mathf.FloorToInt(DistanceLeft);

        var gui = FindObjectOfType<CheckpointUI>();
        gui.DistanceLeft(distanceLeft.ToString() + "m");
    }

}
