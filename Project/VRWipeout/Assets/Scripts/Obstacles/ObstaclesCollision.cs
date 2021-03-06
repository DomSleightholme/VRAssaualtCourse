﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesCollision : MonoBehaviour
{
    private Rigidbody Obstacle;
    public float velocity;
    public float miniumForceImpact;
    private void Start()
    {
        Obstacle = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            velocity = Obstacle.velocity.magnitude;
            
            if(velocity > miniumForceImpact)
            {
                Debug.Log(transform.parent.name + ": " + velocity);

                Vector3 direction = transform.position - collision.transform.position;
                direction.Normalize();

                float collisionForce = collision.impulse.magnitude / Time.deltaTime;
            }

        }
    }
}
