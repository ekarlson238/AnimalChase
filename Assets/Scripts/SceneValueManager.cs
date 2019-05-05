using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneValueManager : MonoBehaviour
{
    /// <summary>
    /// These static bools are used to carry information between scenes
    /// this information is used in the respective scene managers to make the game "remember" the players progress in a scene
    /// Example: The player picks up an item off the ground in a scene; after leaving and returning to the scene the item doesnt reappear
    /// </summary>

    #region key bools
    public static bool keyPickedUp = false;
    public static bool keyInInventory = false;
    public static bool keyUsedDoorOpen = false;
    #endregion

    #region item 1 bools
    public static bool item1PickedUp = false;
    public static bool item1InInventory = false;
    public static bool item1Placed = false;
    #endregion

    #region item 2 bools
    public static bool item2PickedUp = false;
    public static bool item2InInventory = false;
    public static bool item2Placed = false;
    #endregion

    #region item 3 bools
    public static bool item3PickedUp = false;
    public static bool item3InInventory = false;
    public static bool item3Placed = false;
    #endregion

    #region item 4 bools
    public static bool item4PickedUp = false;
    public static bool item4InInventory = false;
    public static bool item4Placed = false;
    #endregion

    #region note bools
    public static bool note1PickedUp = false;
    public static bool note2PickedUp = false;
    public static bool note3PickedUp = false;
    public static bool note4PickedUp = false;
    #endregion
}
