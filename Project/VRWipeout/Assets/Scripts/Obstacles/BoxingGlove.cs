using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingGlove : MonoBehaviour
{
    [Header("Transforms")]
    public Transform PunchGlove;
    public Animator animator;

    [Header("Variables")]
    public float OrignalPosition;
    public float AttackPosition;

    public void Attack()
    {
        animator.SetTrigger("Attack!");
    }
}
