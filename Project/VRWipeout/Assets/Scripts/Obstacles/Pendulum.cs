using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    [Header("Speed")]
    [Range(-3, 3)]
    public float RotationSpeed;

    private void Update()
    {
        //Rotate Pendulum on X Axis
        transform.Rotate(new Vector3(RotationSpeed, 0, 0));
    }
}
