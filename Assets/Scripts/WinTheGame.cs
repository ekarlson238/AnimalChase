using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTheGame : MonoBehaviour
{
    [Tooltip("Enter the name of the scene the portal will take the player")]
    [SerializeField]
    private string desiredSceneName;

    [Tooltip("The black panel that covers the canvas")]
    [SerializeField]
    private Animator fadePanelAnim;

    // Update is called once per frame
    void Update()
    {
        if (SceneValueManager.item1Placed && SceneValueManager.item2Placed && SceneValueManager.item3Placed && SceneValueManager.item4Placed)
        {
            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeOut()
    {
        fadePanelAnim.SetBool("leavingScene", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(desiredSceneName);
    }
}
