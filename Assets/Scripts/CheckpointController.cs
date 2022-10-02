using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    PlayerManager playerManager;
    TimeManager timeManager;
    UIManager uiManager;

    private Vector2 checkpointPosition; 

    void Awake()
    {
        playerManager = transform.parent.gameObject.GetComponent<PlayerManager>();
        timeManager = transform.parent.gameObject.GetComponent<TimeManager>();
        uiManager = transform.parent.gameObject.GetComponent<UIManager>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            // Grab the X and Y values of the checkpoint position
            checkpointPosition = gameObject.transform.position;
            playerManager.spawnPoint = checkpointPosition;
            timeManager.resetTimer();
            uiManager.ShowAdvice(2, 2f);
        }
    }
}
