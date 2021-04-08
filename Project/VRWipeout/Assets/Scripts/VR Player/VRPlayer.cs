using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class VRPlayer : MonoBehaviour
{
    [Header("Camera")]
    public Transform Cam;

    [Header("General Movement")]


    [Header("Sprinting")]
    public GameObject SweatEffect;
    public GameObject SpeedEffect;
    private float SprintValue;
    private float OrignalValue;
    public bool canSprint;
    public float Cooldown;
    public float SpintingTime;
    public bool isSprinting;

    [Header("Jumping")]
    public float JumpForce;
    public bool isGrounded;

    [Header("Climbing")]
    public bool LeftHandClimb;
    public bool RightHandClimb;

    private XRRig Rig;
    public Rigidbody RB;

    private void Awake()
    {
        canSprint = true;
    }

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
        if (isGrounded)
        {
            RB.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }

    //Sprinting
    public void Sprinting(bool on)
    {
        if (on == true)
        {
            isSprinting = true;
            var sprintScript = GetComponent<ActionBasedContinuousMoveProvider>();
            sprintScript.moveSpeed = SprintValue;
            CamEffects(SpeedEffect, Color.white, true);
            SpintingTime += 0.01f;

            if(SpintingTime > 10)
            {
                StartCoroutine(SprintTime());
            }
        }
        if(on == false)
        {
            isSprinting = false;
            var sprintScript = GetComponent<ActionBasedContinuousMoveProvider>();
            sprintScript.moveSpeed = OrignalValue;
            CamEffects(SpeedEffect, Color.white, false);
            SpintingTime = 0f;
        }
    }
    IEnumerator SprintTime()
    {
        CamEffects(SweatEffect, Color.blue, true);
        CamEffects(SpeedEffect, Color.blue, false);
        var sprintScript = GetComponent<ActionBasedContinuousMoveProvider>();
        sprintScript.moveSpeed = OrignalValue;
        canSprint = false;

        yield return new WaitForSeconds(10);
        canSprint = true;
        CamEffects(SweatEffect, Color.blue, false);
    }

    //CameraEffects
    public void CamEffects(GameObject Effect, Color CamColor, bool active)
    {
        Effect.SetActive(active);
    }

    //Collision Detection

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
