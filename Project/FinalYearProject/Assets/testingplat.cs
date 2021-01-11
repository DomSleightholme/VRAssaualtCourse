using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingplat : MonoBehaviour
{
    public float Speed;
    void Update()
    {
        transform.Rotate(0, Speed, 0 * Time.deltaTime);
    }
}
