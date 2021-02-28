using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [Header("Variables")]
    public float FireDelay;
    public float BulletForce;
    public bool isAutomatic;
    [Range(-180f, 0f)]
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
        CannonObject.transform.rotation = Quaternion.Euler(RotationRange,-90,90);
    }

    public void FireCannon()
    {
        Debug.Log("Cannon fire");

        Rigidbody clone;
        clone = Instantiate(Projectile, Barrel.position, Barrel.rotation);

        clone.velocity = transform.TransformDirection(-Vector3.left * BulletForce);
    }
}
