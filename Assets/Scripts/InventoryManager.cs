using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField]
    private InventoryObject key;

    [SerializeField]
    private InventoryObject item1;
    [SerializeField]
    private InventoryObject item2;
    [SerializeField]
    private InventoryObject item3;
    [SerializeField]
    private InventoryObject item4;

    [SerializeField]
    private InventoryObject note1;
    [SerializeField]
    private InventoryObject note2;
    [SerializeField]
    private InventoryObject note3;
    [SerializeField]
    private InventoryObject note4;


    // Start is called before the first frame update
    void Start()
    {
        SetInventory();
    }

    /// <summary>
    /// Makes sure the players inventory doesnt reset when moving between scenes
    /// </summary>
    private void SetInventory()
    {
        if (SceneValueManager.keyPickedUp)
        {
            PlayerInventory.InventoryObjects.Add(key);
            InventoryMenu.Instance.AddItemToMenu(key);
        }


        #region items in inventory
        if (SceneValueManager.item1PickedUp && !SceneValueManager.item1Placed)
        {
            PlayerInventory.InventoryObjects.Add(item1);
            InventoryMenu.Instance.AddItemToMenu(item1);
        }
        if (SceneValueManager.item2PickedUp && !SceneValueManager.item2Placed)
        {
            PlayerInventory.InventoryObjects.Add(item2);
            InventoryMenu.Instance.AddItemToMenu(item2);
        }
        if (SceneValueManager.item3PickedUp && !SceneValueManager.item3Placed)
        {
            PlayerInventory.InventoryObjects.Add(item3);
            InventoryMenu.Instance.AddItemToMenu(item3);
        }
        if (SceneValueManager.item4PickedUp && !SceneValueManager.item4Placed)
        {
            PlayerInventory.InventoryObjects.Add(item4);
            InventoryMenu.Instance.AddItemToMenu(item4);
        }
        #endregion

        #region notes in inventory
        if (SceneValueManager.note1PickedUp)
        {
            PlayerInventory.InventoryObjects.Add(note1);
            InventoryMenu.Instance.AddItemToMenu(note1);
        }
        if (SceneValueManager.note2PickedUp)
        {
            PlayerInventory.InventoryObjects.Add(note2);
            InventoryMenu.Instance.AddItemToMenu(note2);
        }
        if (SceneValueManager.note3PickedUp)
        { 
            PlayerInventory.InventoryObjects.Add(note3);
            InventoryMenu.Instance.AddItemToMenu(note3);
        }
        if (SceneValueManager.note4PickedUp)
        {
            PlayerInventory.InventoryObjects.Add(note4);
            InventoryMenu.Instance.AddItemToMenu(note4);
        }
        #endregion
    }
}
