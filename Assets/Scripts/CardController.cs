using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    [SerializeField] private GameObject targetDoor;
    PlayerManager playerManager;
    TimeManager timeManager;
    UIManager uiManager;

    DoorController doorController;

    private AudioSource audioCard;

    void Awake()
    {
        playerManager = transform.parent.gameObject.GetComponent<PlayerManager>();
        uiManager = transform.parent.gameObject.GetComponent<UIManager>();

        doorController = targetDoor.GetComponent<DoorController>();
        audioCard = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            doorController.isCracked = true;
            // Grab the X and Y values of the checkpoint position
            uiManager.ShowAdvice(1, 2f);
            audioCard.Play();
            // gameObject.SetActive(false);
        }
    }
}
