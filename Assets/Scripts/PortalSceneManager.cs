using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSceneManager : MonoBehaviour
{
    #region items stolen from normal world
    [SerializeField]
    private GameObject item1;
    [SerializeField]
    private GameObject item2;
    [SerializeField]
    private GameObject item3;
    [SerializeField]
    private GameObject item4;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        SetTheScene();
    }

    /// <summary>
    /// After changing back to this scene, change the scene back to what it was like when the player left
    /// </summary>
    private void SetTheScene()
    {
        //REMEMBER TO CHANGE THE DOOR TO OPEN AFTER OPENNING IT - (DO THIS LATER) ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        #region items picked up
        if (SceneValueManager.item1PickedUp)
        {
            item1.SetActive(false);
        }

        if (SceneValueManager.item2PickedUp)
        {
            item2.SetActive(false);
        }

        if (SceneValueManager.item3PickedUp)
        {
            item3.SetActive(false);
        }

        if (SceneValueManager.item4PickedUp)
        {
            item4.SetActive(false);
        }
        #endregion
    }
}
