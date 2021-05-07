using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject FirstPosition;
    public GameObject SecondPosition;

    private Vector3 Pos1;
    private Vector3 Pos2;

    public float Speed = 1;

    private void Start()
    {
        Pos1 = FirstPosition.transform.position;
        Pos2 = SecondPosition.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(Pos1, Pos2, Mathf.PingPong(Time.time * Speed, 1));
    }
}
