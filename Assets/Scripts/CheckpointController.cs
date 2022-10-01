using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    PlayerManager playerManager;

    private Vector2 checkpointPosition; 

    void Awake()
    {
        playerManager = transform.parent.gameObject.GetComponent<PlayerManager>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            // Grab the X and Y values of the checkpoint position
            checkpointPosition = gameObject.transform.position;
            playerManager.spawnPoint = checkpointPosition;
        }
    }
}
