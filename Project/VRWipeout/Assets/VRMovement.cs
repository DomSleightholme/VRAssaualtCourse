using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class VRMovement : MonoBehaviour
{
    [Header("Movement")]
    public float Speed;
    public float RotationSpeed;

    [Header("Jumping")]
    public float JumpForce;
    public bool isGrounded;

    [Header("XR")]
    public XRNode inputSource;
    private Vector2 inputAxis;
    private Vector2 rotationAxis;
    public XRNode RotationInput;
    private XRNode jumpInput;
    private XRRig Rig;
    private Rigidbody RB;

    [Header("Transforms")]
    public LayerMask groundLayer;
    public Transform Cam;

    private void Start()
    {
        //Access our private components
        Rig = GetComponent<XRRig>();
        RB = GetComponent<Rigidbody>();

        jumpInput = inputSource;
    }

    private void Update()
    {
        FollowHeadset();

        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);

        InputDevice rotationDevice = InputDevices.GetDeviceAtXRNode(RotationInput);
        rotationDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out rotationAxis);
    }

    private void FixedUpdate()
    {
        //Position
        Quaternion headYaw = Quaternion.Euler(0, Rig.cameraGameObject.transform.eulerAngles.y, 0);
        Vector3 direction = headYaw * new Vector3(inputAxis.x, RB.velocity.y, inputAxis.y) * Time.fixedDeltaTime * Speed;
        RB.MovePosition(RB.position + direction);

        //Rotation
        Vector3 rotation = rotationAxis * Time.fixedDeltaTime * RotationSpeed;
        transform.Rotate(transform.localRotation.x, rotation.x, transform.localRotation.x);

        //Jump
        InputDevice jumpController = InputDevices.GetDeviceAtXRNode(jumpInput);
        jumpController.TryGetFeatureValue(CommonUsages.primaryButton, out bool jumpPressed);
        if (jumpPressed)
            Jump();
    }

    public bool Jump()
    {
        if (isGrounded)
        {
            RB.AddForce(Vector3.up * JumpForce * Time.fixedDeltaTime, ForceMode.Impulse);
            return true;
        }
        else
        {
            return false;
        }
    }

    void FollowHeadset()
    {
        CapsuleCollider capsuleCollider = GetComponent<CapsuleCollider>();
        capsuleCollider.height = Rig.cameraInRigSpaceHeight;
        Cam.transform.localPosition = new Vector3(0, 1, 0);
        Vector3 capsuleCenter = transform.InverseTransformPoint(Rig.cameraGameObject.transform.position);
        capsuleCollider.center = new Vector3(capsuleCenter.x, capsuleCollider.height / 2 + capsuleCollider.radius, capsuleCenter.z);
    }  

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
