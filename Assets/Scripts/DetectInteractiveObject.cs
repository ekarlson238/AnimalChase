using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// detects if an object a player looking to is interactable
/// </summary>
public class DetectInteractiveObject : MonoBehaviour
{
    [Tooltip("Starting point of raycast used to detect interactions")]
    [SerializeField]
    private Transform raycastOrgin;

    [Tooltip("How far from the raycast orgin we search for interactive objects")]
    [SerializeField]
    private float maxRange = 2.5f;

    /// <summary>
    /// event raised when the player looks at a different IInteractive
    /// </summary>
    public static event Action<IInteractive> LookedAtInteractiveChanged;

    public IInteractive LookedAtInteractive
    {
        get { return lookedAtInteractive; }
        private set
        {
            bool isInteractiveChanged = value != lookedAtInteractive;
            if (isInteractiveChanged)
            {
                lookedAtInteractive = value;

                if (LookedAtInteractiveChanged != null)
                    LookedAtInteractiveChanged.Invoke(lookedAtInteractive);
            }

        }
    }

    private IInteractive lookedAtInteractive;

    private void FixedUpdate()
    {
        LookedAtInteractive = GetLookedAtInteractive();

    }

    /// <summary>
    /// raycasts forwards from camera to look for IInteractive
    /// </summary>
    /// <returns></returns>
    private IInteractive GetLookedAtInteractive()
    {
        Debug.DrawRay(raycastOrgin.position, raycastOrgin.forward * maxRange, Color.red);
        RaycastHit hitInfo;
        bool objectDetected = Physics.Raycast(raycastOrgin.position, raycastOrgin.forward, out hitInfo, maxRange);

        IInteractive interactive = null;

        if (objectDetected)
        {
            //Debug.Log("Player is looking at: " + hitInfo.collider.gameObject.name);

            interactive = hitInfo.collider.gameObject.GetComponent<IInteractive>();

        }
        
        return interactive;

    }
}
