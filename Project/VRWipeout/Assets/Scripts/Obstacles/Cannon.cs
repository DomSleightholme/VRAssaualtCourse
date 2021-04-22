using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [Header("Variables")]
    public float FireDelay;
    public float BulletForce;
    public bool isAutomatic;
    [Range(-45f, 45f)]
    public float RotationRange;

    [Header("Transforms")]
    public Transform Barrel;
    public Rigidbody Projectile;
    public GameObject CannonObject;

    private void Start()
    {
        if (isAutomatic)
        {
            InvokeRepeating("FireCannon", 1.0f, FireDelay);
        }
    }

    public void Update()
    {
        CannonObject.transform.localRotation = Quaternion.Euler(0,0, RotationRange);

        Barrel.rotation = CannonObject.transform.rotation;
    }

    public void FireCannon()
    {
        Debug.Log("Cannon fire");

        Rigidbody clone;
        clone = Instantiate(Projectile, Barrel.position, CannonObject.transform.localRotation);

        clone.velocity = transform.TransformDirection(new Vector3(BulletForce, 0, 0));
    }
}
