﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ArmSwingingMovement : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject LeftHand;
    public GameObject RightHand;

    [Header("Multipler")]
    public float Multipler;

    //Vector3 positions
    private Vector3 PositionPreviousFrameLeftHand;
    private Vector3 PositionPreviousFrameRightHand;
    private Vector3 PlayerPositionPreviousFrame;
    private Vector3 PlayerPositionThisFrame;
    private Vector3 PositionThisFrameLeftHand;
    private Vector3 PositionThisFrameRightHand;

    //Speed
    public float HandSpeed;

    bool isSprinting;

    //Classes
    private GameManager gameManager;
    public VRControllers playerInput;

    private void Awake()
    {
        playerInput = new VRControllers();
        playerInput.Player.Sprinting.performed += _ => isSprinting = true;
        playerInput.Player.Sprinting.canceled += _ => isSprinting = false;
    }

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        //Set original Previous frame positions at start up
        PlayerPositionPreviousFrame = transform.position;
        PositionPreviousFrameLeftHand = LeftHand.transform.position;
        PositionPreviousFrameRightHand = RightHand.transform.position;
    }

    public void Update()
    {

       if(gameManager.VRInput == true)
        {
            //Get current positions of hands
            PositionThisFrameLeftHand = LeftHand.transform.position;
            PositionThisFrameRightHand = RightHand.transform.position;
            //Position of the Player
            PlayerPositionThisFrame = transform.position;

            //Get distance the hands and player has moved since the last frame
            var playerDistanceMove = Vector3.Distance(PlayerPositionThisFrame, PlayerPositionPreviousFrame);
            var leftHandDistanceMoved = Vector3.Distance(PositionPreviousFrameLeftHand, PositionThisFrameLeftHand);
            var rightHandDistanceMoved = Vector3.Distance(PositionThisFrameRightHand, PositionPreviousFrameRightHand);

            //Add them up to get the handspeed from the user minus the movement of the player to neglegt the move of the player from the equeation
            HandSpeed = ((leftHandDistanceMoved - playerDistanceMove) + (rightHandDistanceMoved - playerDistanceMove));
            HandSpeed = Mathf.Round(HandSpeed * 100f) / 100f;

           

            //Set pervious positions of hands for the next frame
            PositionPreviousFrameLeftHand = PositionThisFrameLeftHand;
            PositionPreviousFrameRightHand = PositionThisFrameRightHand;
            //Set Player Position previous frame
            PlayerPositionPreviousFrame = PlayerPositionThisFrame;
        }
    }



    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }
}