using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// detects if the player presses the interact button
/// </summary>
public class InteractWithLookedAt : MonoBehaviour
{
    private IInteractive lookedAtInteractive;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && lookedAtInteractive != null)
        {
            Debug.Log("Pressed Fire");
            lookedAtInteractive.interactWith();
        }
    }

    /// <summary>
    /// Event handler for DetectInteractiveObject.LookedAtInteractiveChanged
    /// </summary>
    /// <param name="newLookedAtInteractive"></param>
    private void OnLookedAtInteractiveChanged(IInteractive newLookedAtInteractive)
    {
        lookedAtInteractive = newLookedAtInteractive;
    }

    #region event subscription / unsubscription
    private void OnEnable()
    {
        DetectInteractiveObject.LookedAtInteractiveChanged += OnLookedAtInteractiveChanged;
    }

    private void OnDisable()
    {
        DetectInteractiveObject.LookedAtInteractiveChanged -= OnLookedAtInteractiveChanged;
    }
    #endregion

}
