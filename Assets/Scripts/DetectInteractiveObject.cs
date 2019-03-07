using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// detects if an object a player looking to is interactable
/// </summary>
public class DetectInteractiveObject : MonoBehaviour
{
    [Tooltip("Starting point of raycast used to detect interactions")]
    [SerializeField]
    private Transform raycastOrgin;

    [Tooltip("How far from the raycast orgin we search for interactive objects")]
    [SerializeField]
    private float maxRange = 2.5f;

    private void FixedUpdate()
    {
        Debug.DrawRay(raycastOrgin.position, raycastOrgin.forward * maxRange, Color.red);
        RaycastHit hitInfo;
        bool objectDetected = Physics.Raycast(raycastOrgin.position, raycastOrgin.forward, out hitInfo, maxRange);

        if (objectDetected)
        {
            Debug.Log("Player is looking at: " + hitInfo.collider.gameObject.name);
        }


    }
}
