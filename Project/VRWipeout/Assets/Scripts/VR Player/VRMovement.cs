using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class VRMovement : MonoBehaviour
{
    [Header("Movement")]
    public float Speed;
    public float RotationSpeed;
    private float OrignalValue;

    [Header("Ground Dectection")]
    public bool isGrounded;
    public float JumpForce;
    public bool Crouching;

    [Header("XR")]
    public XRNode inputSource;
    private Vector2 inputAxis;
    private Vector2 rotationAxis;
    public XRNode RotationInput;
    public bool Gamepad;

    [Header("Haptic Feedback")]
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

        jumpInput = RotationInput;
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

                //Movement
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
                if (settings.RealCrouch == false)
                {
                    if (Input.GetButton("Crouch"))
                    {
                        Crouch(true);
                    }
                    else
                    {
                        Crouch(false);
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
                if(settings.RealCrouch == false)
                {
                    InputDevice crouch = InputDevices.GetDeviceAtXRNode(inputSource);
                    crouch.TryGetFeatureValue(CommonUsages.primaryButton, out bool crouchPressed);
                    if (crouchPressed)
                    {
                        Crouch(true);
                    }
                    else
                    {
                        Crouch(false);
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
            }
        }
    }

    public void Jump()
    {
        if (isGrounded)
        {
            RB.velocity += JumpForce * Vector3.up;
            isGrounded = false;

            if (Gamepad == false)
            {
                HapticInput(HapticAmp, HapticDuration);
            }
        }
    }

    public void Crouch(bool on)
    {
        if (on)
        {
            if (isGrounded && transform.localScale.y > 0.75f)
            {
                transform.localScale -= new Vector3(0, 0.25f, 0);
            }
        }
        else
        {
            if(transform.localScale.y < 1)
            {
                transform.localScale += new Vector3(0, 0.25f, 0);
            }
        }
    }
    
    void FollowHeadset()
    {
        //Get the capsule component
        CapsuleCollider capsuleCollider = GetComponent<CapsuleCollider>();
        capsuleCollider.height = Rig.cameraInRigSpaceHeight;
        Cam.transform.localPosition = new Vector3(0, 1, 0);

        //Adjust the capsule collider size to fit with the players headset
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
        if (collision.transform.CompareTag("BouncingBall"))
        {
            RB.velocity += JumpForce * Vector3.up;
            isGrounded = false;
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
            respawnscript.PlayerRespawn();
        }
        if (other.transform.CompareTag("Finish"))
        {
            var levelManager = FindObjectOfType<LevelManager>();
            levelManager.LevelComplete();
        }
    }

    public void HapticInput(float amp, float duration)
    {
        for(int i = 0; i < Hands.Count; i++)
        {
            Hands[i].SendHapticImpulse(amp, duration);
        }
    }
}
