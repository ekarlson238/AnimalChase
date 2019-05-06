using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class InteractiveObject : MonoBehaviour, IInteractive
{
    protected AudioSource audioSource;

    [Tooltip("Test that will display in the UI in the world")]
    [SerializeField]
    protected string displayText = "Interactive Object";

    public virtual string DisplayText => displayText;

    protected virtual void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public virtual void InteractWith()
    {
        try
        {
            audioSource.Play();
        }
        catch (System.Exception)
        {
            throw new System.Exception("Interactive Object requires an Audio Source with an audio clip assigned");
        }

        Debug.Log("Player just interacted with " + gameObject.name);
    }
}
