using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ConinuousMovement : MonoBehaviour
{
    public XRNode inputSource;
    private Vector2 inputAxis;
    private CharacterController Character;
    public float Speed;
    private XRRig Rig;

    public LayerMask groundLayer;
    public float Gravity;
    private float fallingSpeed;

    public float additionalHeight;

    // Start is called before the first frame update
    void Start()
    {
        Character = GetComponent<CharacterController>();

        Rig = GetComponent<XRRig>();
    }

    // Update is called once per frame
    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);         
    }

    private void FixedUpdate()
    {
        Quaternion headYaw = Quaternion.Euler(0, Rig.cameraGameObject.transform.eulerAngles.y, 0);
        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);

        Character.Move(direction * Time.fixedDeltaTime * Speed);

        //gravity
        bool isGrounded = CheckIfGrounded();
        if (isGrounded)
        {
            fallingSpeed = 0;
        }
        else
        {
            fallingSpeed += Gravity * Time.fixedDeltaTime;
        }
        
        Character.Move(Vector3.up * fallingSpeed * Time.fixedDeltaTime);

        CapsuleFollowHeadset();
    }

    bool CheckIfGrounded()
    {
        //tells if grounded
        Vector2 rayStart = transform.TransformPoint(Character.center);
        float rayLength = Character.center.y + 0.01f;

        bool hasHit = Physics.SphereCast(rayStart, Character.radius, Vector3.down, out RaycastHit hitInfo, groundLayer);

        return hasHit;
    }

    void CapsuleFollowHeadset()
    {
        Character.height = Rig.cameraInRigSpaceHeight + additionalHeight;
        Vector3 capsuleCenter = transform.InverseTransformPoint(Rig.cameraGameObject.transform.position);
        Character.center = new Vector3(capsuleCenter.x, Character.height / 2 + Character.skinWidth, capsuleCenter.z);
    }
}
