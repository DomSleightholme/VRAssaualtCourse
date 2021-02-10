using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class VRPlayer : MonoBehaviour
{
    [Header("Camera")]
    public Transform Cam;

    [Header("Sprinting")]
    public float SprintValue;
    public float OrignalValue;
    public bool isSprinting;

    [Header("Jumping")]
    public InputActionProperty jump;

    private XRRig Rig;
    private Rigidbody RB;

    private void Start()
    {
        Rig = GetComponent<XRRig>();
        RB = GetComponent<Rigidbody>();

        //Get Value of Move Speed
        var sprintScript = GetComponent<ActionBasedContinuousMoveProvider>();
        OrignalValue = sprintScript.moveSpeed;
        SprintValue = OrignalValue * 2;
    }

    private void FixedUpdate()
    {
        FollowHeadset();
        if (isSprinting)
        {
            Sprinting();
        }
        else
        {
            var sprintScript = GetComponent<ActionBasedContinuousMoveProvider>();
            sprintScript.moveSpeed = OrignalValue;
        }
            
    }

    void FollowHeadset()
    {
        CapsuleCollider capsuleCollider = GetComponent<CapsuleCollider>();
        capsuleCollider.height = Rig.cameraInRigSpaceHeight;
        Cam.transform.localPosition = new Vector3(0,1,0);
        Vector3 capsuleCenter = transform.InverseTransformPoint(Rig.cameraGameObject.transform.position);
        capsuleCollider.center = new Vector3(capsuleCenter.x, capsuleCollider.height / 2 + capsuleCollider.radius, capsuleCenter.z);
    }
    public void Jump()
    {
        RB.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }

    public void Sprinting()
    {
        var sprintScript = GetComponent<ActionBasedContinuousMoveProvider>();
        sprintScript.moveSpeed = SprintValue;
    }

    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        
    }
}
