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
    private float OrignalValue;

    [Header("Sprinting")]
    public float SprintSpeed;
    public GameObject SpeedEffect;
    public bool isSprinting;

    [Header("Ground Dectection")]
    public bool isGrounded;

    [Header("Jumping")]
    public float JumpForce;  

    [Header("XR")]
    public XRNode inputSource;
    private Vector2 inputAxis;
    private Vector2 rotationAxis;
    public XRNode RotationInput;
    public bool Gamepad;
    public List<XRController> Hands;
    public float HapticAmp;
    public float HapticDuration;
    private XRNode jumpInput;
    private XRNode pauseInput;
    private XRRig Rig;
    private Rigidbody RB;

    [Header("Transforms")]
    public Transform Cam;

    private Settings settings;

    private void Start()
    {
        //Access our private components
        Rig = GetComponent<XRRig>();
        RB = GetComponent<Rigidbody>();

        jumpInput = inputSource;
        pauseInput = inputSource;

        OrignalValue = Speed;

        settings = FindObjectOfType<Settings>();
    }

    private void Update()
    {
        FollowHeadset();

        //Get Movement Input
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);

        //Get Rotatation Input
        InputDevice rotationDevice = InputDevices.GetDeviceAtXRNode(RotationInput);
        rotationDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out rotationAxis);
    }

    private void FixedUpdate()
    {
        var levelManager = FindObjectOfType<LevelManager>();
        if (levelManager.LevelRunning)
        {
            if(Gamepad == true)
            {
                //Position
                float x = Input.GetAxis("Horizontal");
                float z = Input.GetAxis("Vertical");

                Quaternion headYaw = Quaternion.Euler(0, Rig.cameraGameObject.transform.eulerAngles.y, 0);
                Vector3 direction = headYaw * new Vector3(x, RB.velocity.y, z) * Time.fixedDeltaTime * Speed;
                RB.MovePosition(RB.position + direction);

                //Rotation
                float rot = Input.GetAxis("Rotate");
                Vector3 gamepadRotation = new Vector3(0,rot,0) * Time.fixedDeltaTime * RotationSpeed;
                transform.Rotate(transform.localRotation.x, gamepadRotation.y, transform.localRotation.z);

                //Jump
                if (Input.GetButtonDown("Jump"))
                {
                    Jump();
                }

                //Crouch
                if (settings.RealCouch == false)
                {
                    if (Input.GetButtonDown("Couch"))
                    {
                        Crouch();
                    }
                }

                //Pause
                if (Input.GetButtonDown("Pause"))
                {
                    var pauseMenu = FindObjectOfType<PauseMenu>();
                    pauseMenu.InputCheck();
                }
            }
            if(Gamepad == false)
            {
                //Position
                Quaternion headYaw = Quaternion.Euler(0, Rig.cameraGameObject.transform.eulerAngles.y, 0);
                Vector3 direction = headYaw * new Vector3(inputAxis.x, RB.velocity.y, inputAxis.y) * Time.fixedDeltaTime * Speed;
                RB.MovePosition(RB.position + direction);

                //Jump
                InputDevice jumpController = InputDevices.GetDeviceAtXRNode(jumpInput);
                jumpController.TryGetFeatureValue(CommonUsages.primaryButton, out bool jumpPressed);
                if (jumpPressed)
                {
                    Jump();                
                }

                //Crouch
                if(settings.RealCouch == false)
                {
                    InputDevice crouch = InputDevices.GetDeviceAtXRNode(inputSource);
                    crouch.TryGetFeatureValue(CommonUsages.primaryButton, out bool crouchPressed);
                    if (crouchPressed)
                    {
                        Crouch();
                    }
                }

                //Rotation
                Vector3 rotation = rotationAxis * Time.fixedDeltaTime * RotationSpeed;
                transform.Rotate(transform.localRotation.x, rotation.x, transform.localRotation.x);

                //Pause
                InputDevice pause = InputDevices.GetDeviceAtXRNode(pauseInput);
                pause.TryGetFeatureValue(CommonUsages.menuButton, out bool playerPause);
                if (playerPause)
                {
                    var pauseMenu = FindObjectOfType<PauseMenu>();
                    pauseMenu.InputCheck();
                }


                InputDevice sprint = InputDevices.GetDeviceAtXRNode(inputSource);
                sprint.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out bool sprintPressed);
                if (sprintPressed)
                {
                    Sprinting(true);
                }
                else
                {
                    Sprinting(false);
                }
            }
        }
    }

    public void Jump()
    {
        if (isGrounded)
        {
            RB.velocity += JumpForce * Vector3.up * Time.deltaTime;

            if(Gamepad == false)
            {
                HapticInput(HapticAmp, HapticDuration);
            }
        }
    }

    public void Crouch()
    {
        if (isGrounded)
        {

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

    //GroundDetection
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Death"))
        {
            var respawnscript = FindObjectOfType<Respawn>();
            respawnscript.PlayerDeath();
        }
        if (other.transform.CompareTag("Finish"))
        {
            var levelManager = FindObjectOfType<LevelManager>();
            levelManager.LevelComplete();
        }
    }

    //Camera Effects
    public void Sprinting(bool on)
    {
        if (on == true)
        {
            isSprinting = true;
            Speed = SprintSpeed;
            CamEffects(SpeedEffect, Color.white, true);
        }
        if (on == false)
        {
            isSprinting = false;
            Speed = OrignalValue;
            CamEffects(SpeedEffect, Color.white, false);
        }
    }

    //CameraEffects
    public void CamEffects(GameObject Effect, Color CamColor, bool active)
    {
        Effect.SetActive(active);
    }

    public void HapticInput(float amp, float duration)
    {
        for(int i = 0; i < Hands.Count; i++)
        {
            Hands[i].SendHapticImpulse(amp, duration);
        }
    }
}
