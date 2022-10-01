using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject playerObject;

    [SerializeField] private GameObject playerSpawnPoint;
    [SerializeField] private GameObject playerPrefab;

    private Vector2 spawnPoint;

    private UIManager uiManager;

    void Awake()
    {
        spawnPoint = playerSpawnPoint.transform.position;
        uiManager = GetComponent<UIManager>();

        // НАДО СДЕЛАТЬ СПАВН ИНСТАНСА ИГРОКА В ТОЧКЕ СПАВНА НА УРОВНЕ!!! (НЕ РАБОТАЕТ НИФИГА!!)
        // Instantiate(playerPrefab, playerSpawnPoint.transform, playerSpawnPoint.transform);
    }

    public void ResetPlayer()
    {
        playerObject.transform.position = spawnPoint;
    }

  
}
