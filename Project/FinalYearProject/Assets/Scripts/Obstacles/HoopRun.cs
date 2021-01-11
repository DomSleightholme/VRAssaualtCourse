using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopRun : MonoBehaviour
{
    [Header("Speed")]
    [Range(0, 200)]
    public float RotationSpeed;
    public float minSpeed;
    public float maxSpeed;

    [Header("Increase Speed")]
    public float increaseMulitpler;
    public bool canIncreaseSpeed;

    private void Update()
    {
        Rotate();

        if (canIncreaseSpeed)
        {
            IncreaseSpeed();
        }
    }

    void Rotate()
    {
        transform.Rotate(0, 0, RotationSpeed * Time.deltaTime);
    }

    void IncreaseSpeed()
    {
        if (RotationSpeed < maxSpeed)
        {
            RotationSpeed += increaseMulitpler * Time.deltaTime;
        }
    }
}
