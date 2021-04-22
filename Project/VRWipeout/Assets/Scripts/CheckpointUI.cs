using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckpointUI : MonoBehaviour
{
    [Header("Transform")]
    public TMP_Text DistanceLeftGUI;

    public void DistanceLeft(string amount)
    {
        DistanceLeftGUI.text = amount;
    }
}
