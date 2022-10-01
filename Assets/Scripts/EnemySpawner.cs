using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField][Range(0.1f, 10)]
    private float _timer;
    private float _timeToSpawn;
        
    [SerializeField]
    private GameObject _enemyPref;
    [SerializeField]
    private GameObject _spawnPoint;

    private int _spawnCount = 10;

    private void Update()
    {
        if (_timeToSpawn <= 0)
        {
            StartCoroutine(SpawnEnemy());
            _timeToSpawn = _timer;
        }

        _timeToSpawn -= Time.deltaTime;
    }

    private IEnumerator SpawnEnemy()
    {
        var enemy = Instantiate(_enemyPref, _spawnPoint.transform.position, Quaternion.identity);

        yield return null;
    }
}
