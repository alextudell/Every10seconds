using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject playerSpawnPoint;
    [SerializeField] private GameObject playerPrefab;

    public Vector2 spawnPoint;

    private UIManager uiManager;

    void Awake()
    {
        spawnPoint = playerSpawnPoint.transform.position;
        uiManager = GetComponent<UIManager>();
        ResetPlayer();
        PlayerPrefs.SetInt("LastLevel", SceneManager.GetActiveScene().buildIndex);
    }

    public void ResetPlayer()
    {
        playerObject.transform.position = spawnPoint;
    }

  
}
