using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : InteractiveObject
{
    [Tooltip("Name of the object as it will appear in inventory UI")]
    [SerializeField]
    private string objectName = nameof(InventoryObject);

    [Tooltip("The icon that will display in the inventory")]
    [SerializeField]
    private Sprite icon;

    [Tooltip("The text that will display in the inventory")]
    [TextArea(3,8)]
    [SerializeField]
    private string discription;

    private new Renderer renderer;
    private new Collider collider;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        collider = GetComponent<Collider>();
    }

    /// <summary>
    /// Using a constructor to initialize display text
    /// </summary>
    public InventoryObject()
    {
        displayText = "Take " + objectName;
    }


    /// <summary>
    /// when the player interacts with an inventory object
    /// 1 add the object to the player inventory list
    /// 2 remove it from the world
    /// disable collider and renderer
    /// </summary>
    public override void InteractWith()
    {
        base.InteractWith();
        PlayerInventory.InventoryObjects.Add(this);
        renderer.enabled = false;
        collider.enabled = false;
    }

}
