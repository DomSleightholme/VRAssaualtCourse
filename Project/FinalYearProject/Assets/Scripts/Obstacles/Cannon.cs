using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [Header("Variables")]
    public float FireDelay;
    [Range(-180f, 0f)]
    public float RotationRange;

    [Header("Transforms")]
    public GameObject Bullet;
    public GameObject CannonObject;

    public void Update()
    {
        CannonObject.transform.rotation = Quaternion.Euler(RotationRange,-90,90);
    }

    public void FireCannon()
    {
        Debug.Log("Cannon fire");
    }
}
