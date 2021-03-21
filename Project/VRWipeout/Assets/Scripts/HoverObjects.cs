using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverObjects : MonoBehaviour
{
    public Transform Wings;
    public float WingSpeed;
    void Update()
    {
        Wings.transform.Rotate(0, WingSpeed * Time.deltaTime, 0);
    }
}
