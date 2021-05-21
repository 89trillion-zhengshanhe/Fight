using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("isAttack");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("isRun");
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            animator.SetTrigger("isIdle");
        }
    }
}
