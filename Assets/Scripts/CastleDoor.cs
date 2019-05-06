using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Animator))]
public class CastleDoor : InteractiveObject
{
    [Tooltip("Check this box to lock door")]
    [SerializeField]
    private bool isLocked;

    [Tooltip("What text the door diplays when locked")]
    [SerializeField]
    private string lockedDisplayText = "Locked";

    [Tooltip("Plays this when the door is interacted with and locked without the key")]
    [SerializeField]
    private AudioClip lockedAudioClip;

    [Tooltip("Plays this when the door is opened")]
    [SerializeField]
    private AudioClip openAudioClip;

    public override string DisplayText => isLocked ? lockedDisplayText : base.DisplayText;

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
            if (!isLocked)
            {
                audioSource.clip = openAudioClip;
                animator.SetBool("shouldOpen", true);
                displayText = string.Empty;
                isOpen = true;
            }
            else //if door is locked...
            {
                audioSource.clip = lockedAudioClip;
            }
            base.interactWith();
        }
        
    }
}
