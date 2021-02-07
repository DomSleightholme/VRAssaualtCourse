using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningSpikes : MonoBehaviour
{
    [Header("Speed")]
    [Range(0, 200)]
    public float RotationSpeed;
    public float minSpeed;
    public float maxSpeed;

    [Header("Increase Speed")]
    public float increaseMulitpler;
    public bool canIncreaseSpeed;
    private Rigidbody RB;

    private void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

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
        Quaternion deltaRotation = Quaternion.Euler(RotationSpeed, 0, 0 * Time.deltaTime);
        RB.MoveRotation(RB.rotation * deltaRotation);
    }

    void IncreaseSpeed()
    {
        if (RotationSpeed < maxSpeed)
        {
            RotationSpeed += increaseMulitpler * Time.deltaTime;
        }
    }
}
