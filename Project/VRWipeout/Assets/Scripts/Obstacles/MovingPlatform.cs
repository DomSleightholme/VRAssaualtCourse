using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [Header("Transforms")]
    public GameObject FirstPosition;
    public GameObject SecondPosition;

    [Header("Variables")]
    public float Speed = 1;

    private Vector3 Pos1;
    private Vector3 Pos2;

    private void Start()
    {
        Pos1 = FirstPosition.transform.position;
        Pos2 = SecondPosition.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(Pos1, Pos2, Mathf.PingPong(Time.time * Speed, 1));
    }
}
