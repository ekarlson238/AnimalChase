using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSceneStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        ResetSceneValueManager();
    }

    private void ResetSceneValueManager()
    {
        SceneValueManager.playerEnteredPortal = false;

        #region key bools
        SceneValueManager.keyPickedUp = false;
        SceneValueManager.keyUsedDoorOpen = false;
        #endregion

        #region item bools
        SceneValueManager.item1PickedUp = false;
        SceneValueManager.item1Placed = false;

        SceneValueManager.item2PickedUp = false;
        SceneValueManager.item2Placed = false;

        SceneValueManager.item3PickedUp = false;
        SceneValueManager.item3Placed = false;

        SceneValueManager.item4PickedUp = false;
        SceneValueManager.item4Placed = false;
        #endregion

        #region note bools
        SceneValueManager.note1PickedUp = false;
        SceneValueManager.note2PickedUp = false;
        SceneValueManager.note3PickedUp = false;
        SceneValueManager.note4PickedUp = false;
        #endregion

    }

    
}


