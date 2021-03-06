﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    [Header("Speed")]
    [Range(0, 3)]
    public float RotationSpeed;

    [Header("Distance")]
    public float MaxLeft;
    public int MaxRight;
    float Rotation;
    bool Left;

    private void Start()
    {
        
    }

    private void Update()
    {
       if(Left == true)
        {
            transform.Rotate(new Vector3(0, 0, -RotationSpeed));
        }
        else
        {
            transform.Rotate(new Vector3(0, 0, RotationSpeed));
        }

        if (transform.eulerAngles.z >= MaxRight && transform.eulerAngles.z <= MaxRight + 5)
        {
            Left = true;
        }

        if(transform.eulerAngles.z >= MaxLeft && transform.eulerAngles.z <= MaxLeft + 5)
        {
            Left = false;
        }
    }
}
