using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Animator))]
public class CastleDoor : InteractiveObject
{
    [Tooltip("Assigning a key here will lock the door, door can only be opened if player has a key")]
    [SerializeField]
    private InventoryObject key;

    [Tooltip("What text the door diplays when locked")]
    [SerializeField]
    private string lockedDisplayText = "Locked";

    [Tooltip("Plays this when the door is interacted with and locked without the key")]
    [SerializeField]
    private AudioClip lockedAudioClip;

    [Tooltip("Plays this when the door is opened")]
    [SerializeField]
    private AudioClip openAudioClip;

    private bool isLocked;
    private bool hasKey => PlayerInventory.InventoryObjects.Contains(key);

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
        InitializeIsLocked();
    }

    private void InitializeIsLocked()
    {
        if (key != null)
        {
            isLocked = true;
        }
    }

    public override void InteractWith()
    {
        if (!isOpen)
        {
            if (isLocked && !hasKey)
            {
                audioSource.clip = lockedAudioClip;
            }
            else
            {
                audioSource.clip = openAudioClip;
                animator.SetBool("shouldOpen", true);
                displayText = string.Empty;
                isOpen = true;
            }
            base.InteractWith();
        }
        
    }
}
