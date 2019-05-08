using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : InteractiveObject
{
    [Tooltip("Enter the name of the scene the portal will take the player")]
    [SerializeField]
    private string desiredSceneName;

    [Tooltip("The black panel that covers the canvas")]
    [SerializeField]
    private Animator fadePanelAnim;

    public override void InteractWith()
    {
        base.InteractWith();
        SceneValueManager.playerEnteredPortal = true;
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        fadePanelAnim.SetBool("leavingScene", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(desiredSceneName);
    }
}
