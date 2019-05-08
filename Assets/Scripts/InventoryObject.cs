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
    private string description;

    public string ObjectName => objectName;
    public Sprite Icon => icon;
    public string Description => description;

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
        InventoryMenu.Instance.AddItemToMenu(this);
        renderer.enabled = false;
        collider.enabled = false;
        SceneItemTracking();
    }

    /// <summary>
    /// Keeps track of what the player has picked up and records it in the scene value manager
    /// </summary>
    private void SceneItemTracking()
    {
        #region Notes
        if (this.objectName == "Note 1")
            SceneValueManager.note1PickedUp = true;
        if (this.objectName == "Note 2")
            SceneValueManager.note2PickedUp = true;
        if (this.objectName == "Note 3")
            SceneValueManager.note3PickedUp = true;
        if (this.objectName == "Note 4")
            SceneValueManager.note4PickedUp = true;
        #endregion

        #region items
        if (this.objectName == "Statue")
            SceneValueManager.item1PickedUp = true;
        if (this.objectName == "Well")
            SceneValueManager.item2PickedUp = true;
        if (this.objectName == "Cart")
            SceneValueManager.item3PickedUp = true;
        if (this.objectName == "Campfire")
            SceneValueManager.item4PickedUp = true;
        #endregion

        if (this.objectName == "Key")
            SceneValueManager.keyPickedUp = true;

    }

}
