using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ConinuousMovement : MonoBehaviour
{
    [Header("XR")]
    public XRNode inputSource;    
    private Vector2 inputAxis;
    public CharacterController Character;   
    private XRRig Rig;
    
    [Header("Values")]
    public float Speed;
    public float OrignalSpeed;
    public float additionalHeight;
    public float Gravity;
    private float fallingSpeed;
    Vector2 movementInput;
    Vector2 checkMovement = new Vector2(0, 0);
    public bool isSprinting;

    [Header("Layer Mask")]
    public LayerMask groundLayer;

    [Header("Audio")]
    public AudioSource RunningAudio;
    public float OriginalPitch;
    public float NewPitch;

    [Header("External Classes")]
    private GameManager gameManager;
    public VRControllers controls;

    private void Awake()
    {
        controls = new VRControllers();
        controls.Player.Movement.performed += ctx =>  movementInput = ctx.ReadValue<Vector2>();
    }

    void Start()
    {
        //Gets the Componenets for the Movement
        Character = GetComponent<CharacterController>();
        gameManager = FindObjectOfType<GameManager>();
        Rig = GetComponent<XRRig>();

        OrignalSpeed = Speed;

        this.enabled = false;
    }

    
    void Update()
    {
        //Gets the main VR device and sets it in the script
        UnityEngine.XR.InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxis, out inputAxis);
    }

    public void FixedUpdate()
    {
        Movement();
        checkSpeed();
        AudioPlayer();

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

    void Movement()
    {
        if (gameManager.VRInput == true && gameManager.OtherInput == false)
        {
            Quaternion headYaw = Quaternion.Euler(0, Rig.cameraGameObject.transform.eulerAngles.y, 0);
            Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);

            Character.Move(direction * Time.fixedDeltaTime * Speed);
        }
        else if(gameManager.OtherInput == true && gameManager.VRInput == false)
        {
            Quaternion headYaw = Quaternion.Euler(0, Rig.cameraGameObject.transform.eulerAngles.y, 0);
            Vector3 direction = headYaw * new Vector3(movementInput.x, 0, movementInput.y);

            Character.Move(direction * Time.fixedDeltaTime * Speed);
        }
        else
        {
            //Think of something here!
        }

    }
    void checkSpeed()
    {
        if(inputAxis.x != checkMovement.x && inputAxis.y != checkMovement.y)
        {
            isSprinting = true;
        }
        else
        {
            isSprinting = false;
        }
    }
    bool CheckIfGrounded()
    {
        //tells if grounded
        Vector2 rayStart = transform.TransformPoint(Character.center);
        float rayLength = Character.center.y + 0.01f;
        bool hasHit = Physics.SphereCast(rayStart, Character.radius, Vector3.down, out RaycastHit hitInfo, rayLength, groundLayer);
        return hasHit;
    }
    void CapsuleFollowHeadset()
    {
        Character.height = Rig.cameraInRigSpaceHeight + additionalHeight;
        Vector3 capsuleCenter = transform.InverseTransformPoint(Rig.cameraGameObject.transform.position);
        Character.center = new Vector3(capsuleCenter.x, Character.height / 2 + Character.skinWidth, capsuleCenter.z);
    }   
    public void Collision(Vector3 velocity, float force)
    {
        Debug.Log(velocity);

        velocity.y = 0;

        Character.Move(-velocity.normalized * force * Time.deltaTime);
    }

    void AudioPlayer()
    {
       if(isSprinting == false)
        {
            RunningAudio.Play();           
        }
    }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
}
