using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingGlove : MonoBehaviour
{
    [Header("Transforms")]
    public Transform PunchGlove;
    public Animator animator;
    public void Start()
    {
        InvokeRepeating("Attack", 5, 5);
    }

    public void Attack()
    {
        animator.SetTrigger("Attack!");
    }
}
