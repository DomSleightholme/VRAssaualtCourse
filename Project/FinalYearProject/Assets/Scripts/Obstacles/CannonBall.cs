using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    public float TimeLeft;

    void Start()
    {
        StartCoroutine(DeSpawn());
    }

    IEnumerator DeSpawn()
    {
        yield return new WaitForSeconds(TimeLeft);

        Destroy(gameObject);
    }
}
