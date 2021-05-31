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
    public GameObject CheckpointObject;

    [Header("Transform")]
    public TMP_Text DistanceLeftGUI;


    private void Start()
    {
        DistanceOverall = (CheckpointObject.transform.position - transform.position).magnitude;
        distanceOverall = Mathf.FloorToInt(DistanceOverall);
    }

    public void Update()
    {
        Tracker();       
    }


    public void Tracker()
    {
        DistanceLeft = (CheckpointObject.transform.position - transform.position).magnitude;

        distanceLeft = Mathf.FloorToInt(DistanceLeft);

        DistanceLeftUI(distanceLeft.ToString() + "m");
    }

    public void DistanceLeftUI(string amount)
    {
        DistanceLeftGUI.text = amount;
    }


}
