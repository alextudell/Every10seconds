using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitController : MonoBehaviour
{
    [SerializeField] private string nextLevelName;

    PlayerManager playerManager;
    TimeManager timeManager;
    UIManager uiManager;

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
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
