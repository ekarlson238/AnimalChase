using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceableObject : InteractiveObject
{
    [SerializeField]
    private GameObject item;

    private bool hasItem;

    private void Start()
    {
        if (item.name == "RealStatue" && SceneValueManager.item1PickedUp)
            hasItem = true;
        if (item.name == "RealWell" && SceneValueManager.item2PickedUp)
            hasItem = true;
        if (item.name == "RealCart" && SceneValueManager.item3PickedUp)
            hasItem = true;
        if (item.name == "RealCampfire" && SceneValueManager.item4PickedUp)
            hasItem = true;
    }

    public override string DisplayText
    {
        get
        {
            if (hasItem)
            {
                return "Place " + item.name;
            }
            else
            {
                return string.Empty;
            }
        }
    }

    public override void InteractWith()
    {
        if (hasItem)
        {
            base.InteractWith();

            if (item.name == "RealStatue")
                SceneValueManager.item1Placed = true;
            if (item.name == "RealWell")
                SceneValueManager.item2Placed = true;
            if (item.name == "RealCart")
                SceneValueManager.item3Placed = true;
            if (item.name == "RealCampfire")
                SceneValueManager.item4Placed = true;

            item.SetActive(true);
            this.gameObject.SetActive(false);
        }

    }

}
