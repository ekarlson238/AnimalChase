using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Animator))]
public class CastleDoor : InteractiveObject
{
    private Animator animator;

    private bool isOpen = false;
    
    /// <summary>
    /// Using a constructor to initialize display text
    /// </summary>
    public CastleDoor()
    {
        displayText = nameof(CastleDoor);
    }

    protected override void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
    }

    public override void interactWith()
    {
        if (!isOpen)
        {
            base.interactWith();
            animator.SetBool("shouldOpen", true);
            displayText = string.Empty;
            isOpen = true;
        }
        
    }
}
