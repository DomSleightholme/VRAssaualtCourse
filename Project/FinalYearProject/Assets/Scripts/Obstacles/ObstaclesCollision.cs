using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesCollision : MonoBehaviour
{
    private Rigidbody Obstacle;
    public float velocity;
    public float miniumForceImpact;

    private CollisionDectection collisionDectection;
    private void Start()
    {
        Obstacle = GetComponentInParent<Rigidbody>();
        collisionDectection = FindObjectOfType<CollisionDectection>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            velocity = Obstacle.velocity.magnitude;
            
            if(velocity > miniumForceImpact)
            {
                collisionDectection.isHit = true;
                Debug.LogError(velocity);

                collision.gameObject.SendMessage("Collision", velocity);
            }

        }
    }
}
