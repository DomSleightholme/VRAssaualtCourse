using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbine : MonoBehaviour
{
    [Header("Fan Control")]
    public GameObject Fan;
    [Range(500.0f, 1100.0f)]
    public float RotationSpeed;

    [Header("Raycast")]
    public int Force;
    private Ray ray1;
    private Ray ray2;
    private Ray ray3;
    private Ray ray4;
    public float LineDistance;
    [Range(100.0f, 300.0f)]
    public float DistanceMultipler;
    public Color LineColor;

    [Header("Transforms")]
    public Transform RaycastOrigin;
    public Transform Player;

    [Header("Private Variables")]
    private ConinuousMovement movement;
    private Vector3 forward;
    private Vector3 position1;
    private Vector3 position2;
    private Vector3 position3;
    private Vector3 position4;

    private void Start()
    {
        movement = FindObjectOfType<ConinuousMovement>();
    }
    public void FixedUpdate()
    {
        FanRotation();
        LineMeasure();
        Collision();
    }
    void FanRotation()
    {
        Fan.transform.Rotate(0, 0, RotationSpeed * Time.deltaTime);
    }

    void LineMeasure()
    {
        LineDistance = RotationSpeed / DistanceMultipler;

        //Set Direction for Rays
        Vector3 forward = transform.TransformDirection(-Vector3.forward) * LineDistance;

        //Get Ray Positions
        Vector3 position1 = new Vector3(RaycastOrigin.position.x, RaycastOrigin.position.y, RaycastOrigin.position.z);
        Vector3 position2 = new Vector3(RaycastOrigin.position.x + 1f, RaycastOrigin.position.y + 0.4f, RaycastOrigin.position.z);
        Vector3 position3 = new Vector3(RaycastOrigin.position.x + -1f, RaycastOrigin.position.y + 0.4f, RaycastOrigin.position.z);
        Vector3 position4 = new Vector3(RaycastOrigin.position.x, RaycastOrigin.position.y + 1f, RaycastOrigin.position.z);

        //Draw the Rays
        ray1 = new Ray(position1, forward);
        ray2 = new Ray(position2, forward);
        ray3 = new Ray(position3, forward);
        ray4 = new Ray(position4, forward);
        Debug.DrawRay(position1, forward, LineColor);
        Debug.DrawRay(position2, forward, LineColor);
        Debug.DrawRay(position3, forward, LineColor);
        Debug.DrawRay(position4, forward, LineColor);
    }


    void Collision()
    {
        if (Physics.Raycast(ray1,out RaycastHit hit1, LineDistance))
        {
            if (hit1.collider.CompareTag("Player"))
            {
                DetectDistance();
            }
        }
        else if (Physics.Raycast(ray2, out RaycastHit hit2, LineDistance))
        {
            if (hit2.collider.CompareTag("Player"))
            {
                DetectDistance();
            }
        }
        else if (Physics.Raycast(ray3, out RaycastHit hit3, LineDistance))
        {
            if (hit3.collider.CompareTag("Player"))
            {
                DetectDistance();
            }
        }
        else if (Physics.Raycast(ray4, out RaycastHit hit4, LineDistance))
        {
            if (hit4.collider.CompareTag("Player"))
            {
                DetectDistance();
            }
        }
    }

    void DetectDistance()
    {
        float dist = Vector3.Distance(Player.position, transform.position);
        int distance = Mathf.RoundToInt(dist);

        int speed = Force / distance;

        Debug.LogError(speed);
        movement.Character.Move(new Vector3(speed, 0, 0) * Time.deltaTime);
    }
}
