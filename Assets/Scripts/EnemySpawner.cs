using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField][Range(0.1f, 10)]
    private float _timeToSpawn;
    [SerializeField]
    private GameObject _enemy;

    private int _spawnCount;

    private IEnumerator SpawnEnemy()
    {
        
    }
}
