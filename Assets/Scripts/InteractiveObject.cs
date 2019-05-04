using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class InteractiveObject : MonoBehaviour, IInteractive
{
    private AudioSource audioSource;

    [SerializeField]
    protected string displayText = "Interactive Object";
    public string DisplayText
    {
        get
        {
            return displayText;
        }
    }

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public virtual void interactWith()
    {
        try
        {
            audioSource.Play();
        }
        catch (System.Exception)
        {
            throw new System.Exception("Interactive Object requires an Audio Source");
        }

        Debug.Log("Player just interacted with " + gameObject.name);
    }
}
