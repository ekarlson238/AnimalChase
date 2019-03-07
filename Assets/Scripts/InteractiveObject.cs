using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour, IInteractive
{
    [SerializeField]
    private string displayText = "Interactive Object";
    public string DisplayText
    {
        get
        {
            return displayText;
        }
    }

    public void interactWith()
    {
        Debug.Log("Player just interacted with " + gameObject.name);
    }
}
