using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    [Range(0, 3)]
    public float RotationSpeed;

    public float MaxLeft;
    public int MaxRight;
    float Rotation;

    public bool Left;

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

        if (transform.eulerAngles.z >= MaxRight && transform.eulerAngles.z <= MaxRight + 2)
        {
            Left = true;
        }

        if(transform.eulerAngles.z >= MaxLeft && transform.eulerAngles.z <= MaxLeft + 2)
        {
            Left = false;
        }
    }
}
