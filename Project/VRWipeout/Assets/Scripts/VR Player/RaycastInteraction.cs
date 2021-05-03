using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastInteraction : MonoBehaviour
{
    //Private
    Vector3 forward;
    RaycastHit hit;

    [Header("Variables")]
    public bool canInteract;

    [Header("Raycast")]
    public float raycastLength;
    public LayerMask layerMask;

    void Update()
    {
        forward = transform.TransformDirection(Vector3.forward) * raycastLength;
        Debug.DrawRay(transform.position, forward, Color.red);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.blue);
            canInteract = true;
            Debug.Log("Interaction Object");
        }
    }
}
