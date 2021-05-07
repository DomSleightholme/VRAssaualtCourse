using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObject : MonoBehaviour
{
    public float RotationSpeed;
    public enum RotationAxis { X,Y,Z };
    public RotationAxis rotationAxis;
    private Rigidbody RB;
    private void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        switch (rotationAxis)
        {
            case RotationAxis.Y:
            {
                    Quaternion deltaRotation = Quaternion.Euler(RotationSpeed * Time.deltaTime, 0, 0);
                    RB.MoveRotation(RB.rotation * deltaRotation);
                    break;
            }
            case RotationAxis.X:
            {
                    Quaternion deltaRotation = Quaternion.Euler(0, RotationSpeed * Time.deltaTime, 0);
                    RB.MoveRotation(RB.rotation * deltaRotation);
                    break;
            }
            case RotationAxis.Z:
            {
                    Quaternion deltaRotation = Quaternion.Euler(0,0, RotationSpeed * Time.deltaTime);
                    RB.MoveRotation(RB.rotation * deltaRotation);
                    break;
            }
        }
    }
}
