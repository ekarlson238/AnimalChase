using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Animator))]
public class CastleDoor : InteractiveObject
{
    private Animator animator;
    
    /// <summary>
    /// Using a constructor to initialize display text
    /// </summary>
    public CastleDoor()
    {
        displayText = nameof(CastleDoor);
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
}
