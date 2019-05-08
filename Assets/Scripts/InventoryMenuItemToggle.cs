using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenuItemToggle : MonoBehaviour
{
    [Tooltip("The image used to represent the item in inventory")]
    [SerializeField]
    private Image iconImage;

    public static event Action<InventoryObject> InventoryMenuItemSelected;
    
    private InventoryObject associatedInventoryObject;

    public InventoryObject AssociatedInventoryObject
    {
        get
        {
            return associatedInventoryObject;
        }
        set
        {
            associatedInventoryObject = value;
            iconImage.sprite = associatedInventoryObject.Icon;
        }
    }

    /// <summary>
    /// this will be plugged into the toggles in the edditor
    /// it will be called on toggle clicked
    /// </summary>
    public void InventoryMenuItemWasToggled(bool isOn)
    {
        //only do stuff if the toggle has been selected
        if (isOn)
        {
            InventoryMenuItemSelected?.Invoke(AssociatedInventoryObject);
        }
    }

    private void Awake()
    {
        Toggle toggle = GetComponent<Toggle>();
        ToggleGroup toggleGroup = GetComponentInParent<ToggleGroup>();
        toggle.group = toggleGroup;
    }
}
