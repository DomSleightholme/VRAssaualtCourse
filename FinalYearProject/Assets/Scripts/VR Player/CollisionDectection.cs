using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDectection : MonoBehaviour
{
    private CharacterController controller;
    private ConinuousMovement player;
    public float Speed;
    public float Timer;
    public float forceMulitpler;
    public bool isHit;
    private void Start()
    {
        //Get the Character Controller component and set its collision detection to true
        controller = GetComponent<CharacterController>();
        player = GetComponent<ConinuousMovement>();
        controller.detectCollisions = true;
    }

    //This method is called when the has been a collision with a obstacle
    public void Collision(float Velocity)
    {
        Debug.LogWarning(Velocity);

        Speed = Velocity;
    }

    private void FixedUpdate()
    {
        if(isHit == true)
        {
            controller.Move(-transform.forward * Time.fixedDeltaTime * Speed * forceMulitpler);

            StartCoroutine(KnockbackTimer());
        }
    }

    IEnumerator KnockbackTimer()
    {
        yield return new WaitForSeconds(Timer);

        isHit = false;
        Speed = 0;
    }
}
