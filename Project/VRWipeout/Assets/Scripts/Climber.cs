using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Climber : MonoBehaviour
{
    private Rigidbody RB;
    public static XRController climbingHand;
    private VRMovement player;

    private void Start()
    {
        RB = GetComponent<Rigidbody>();
        player = GetComponent<VRMovement>();
    }

    private void FixedUpdate()
    {
        if (climbingHand)
        {
            player.enabled = false;
            RB.useGravity = false;
            Climb();
        }
        else
        {
            player.enabled = true;
            RB.useGravity = true;
        }
    }

    void Climb()
    {
        InputDevices.GetDeviceAtXRNode(climbingHand.controllerNode).TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 velocity);

        RB.MovePosition(transform.rotation * RB.position + -velocity * Time.fixedDeltaTime);
    }
}
