using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This UI text displays info on the interactive element looked at
/// </summary>
public class LookedAtInteractiveDisplayText : MonoBehaviour
{
    private IInteractive lookedAtInteractive;
    private Text displayText;

    private void Awake()
    {
        displayText = GetComponent<Text>();
        updateDisplayText();
    }

    private void updateDisplayText()
    {
        if (lookedAtInteractive != null)
            displayText.text = lookedAtInteractive.DisplayText;
        else
            displayText.text = string.Empty;
    }

    /// <summary>
    /// Event handler for DetectInteractiveObject.LookedAtInteractiveChanged
    /// </summary>
    /// <param name="newLookedAtInteractive"></param>
    private void OnLookedAtInteractiveChanged(IInteractive newLookedAtInteractive)
    {
        lookedAtInteractive = newLookedAtInteractive;
        updateDisplayText();
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
