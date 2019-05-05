using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalSceneManager : MonoBehaviour
{
    [SerializeField]
    private GameObject key;

    #region items that were missing
    [SerializeField]
    private GameObject item1;
    [SerializeField]
    private GameObject item2;
    [SerializeField]
    private GameObject item3;
    [SerializeField]
    private GameObject item4;
    #endregion

    #region item placeholders
    [SerializeField]
    private GameObject item1Placeholder;
    [SerializeField]
    private GameObject item2Placeholder;
    [SerializeField]
    private GameObject item3Placeholder;
    [SerializeField]
    private GameObject item4Placeholder;
    #endregion

    #region notes
    [SerializeField]
    private GameObject note1;
    [SerializeField]
    private GameObject note2;
    [SerializeField]
    private GameObject note3;
    [SerializeField]
    private GameObject note4;
    #endregion

    // Start is called before the first frame update
    void Awake()
    {
        SetTheScene();
    }

    /// <summary>
    /// After changing back to this scene, change the scene back to what it was like when the player left
    /// </summary>
    private void SetTheScene()
    {
        if (SceneValueManager.keyPickedUp)
        {
            key.SetActive(false);
        }

        #region items placed
        if (SceneValueManager.item1Placed)
        {
            item1.SetActive(true);
            item1Placeholder.SetActive(false);
        }

        if (SceneValueManager.item2Placed)
        {
            item2.SetActive(true);
            item2Placeholder.SetActive(false);
        }

        if (SceneValueManager.item3Placed)
        {
            item3.SetActive(true);
            item3Placeholder.SetActive(false);
        }
    
        if (SceneValueManager.item4Placed)
        {
            item4.SetActive(true);
            item4Placeholder.SetActive(false);
        }
        #endregion

        #region notes picked up
        if (SceneValueManager.note1PickedUp)
        {
            note1.SetActive(false);
        }

        if (SceneValueManager.note2PickedUp)
        {
            note2.SetActive(false);
        }

        if (SceneValueManager.note3PickedUp)
        {
            note3.SetActive(false);
        }

        if (SceneValueManager.note4PickedUp)
        {
            note4.SetActive(false);
        }
        #endregion
    }
}
