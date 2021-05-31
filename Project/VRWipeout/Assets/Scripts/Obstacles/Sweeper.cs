using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sweeper : MonoBehaviour
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
        var levelManager = FindObjectOfType<LevelManager>();
        if (levelManager.LevelRunning)
        {
            Rotate();
        }

        if (canIncreaseSpeed)
        {
            IncreaseSpeed();
        }
    }

    void Rotate()
    {
        Quaternion deltaRotation = Quaternion.Euler(0, RotationSpeed * Time.deltaTime, 0);
        RB.MoveRotation(RB.rotation * deltaRotation);
    }

    void IncreaseSpeed()
    {
        if(RotationSpeed < maxSpeed)
        {
            RotationSpeed += increaseMulitpler * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        Vector3 direction = transform.position - collision.transform.position;
        direction.Normalize();

        float collisionForce = collision.impulse.magnitude / Time.deltaTime;
    }
}
