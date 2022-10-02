using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    [SerializeField] private GameObject targetDoor;
    PlayerManager playerManager;
    TimeManager timeManager;
    UIManager uiManager;
    private bool _cardDestroed;

    [SerializeField] DoorController doorController;

    [SerializeField]private AudioSource audioCard;

    void Awake()
    {
        playerManager = transform.parent.gameObject.GetComponent<PlayerManager>();
        uiManager = transform.parent.gameObject.GetComponent<UIManager>();
        
    }

    private void Update()
    {
        CardDestroed();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            doorController.isCracked = true;
            _cardDestroed = doorController.isCracked;
            // Grab the X and Y values of the checkpoint position
            uiManager.ShowAdvice(1, 2f);
            audioCard.Play();
            gameObject.SetActive(false);
        }
    }

    private void CardDestroed()
    {
        if (_cardDestroed)
        {
            Destroy(gameObject);
        }
    }
}
