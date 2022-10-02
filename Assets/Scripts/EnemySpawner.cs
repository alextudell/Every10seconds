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

    [SerializeField]
    private int _maxEnemyCount;
    
    private int _enemyCount;

    private AudioSource spawnSound;

    void Start()
    {
        spawnSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (_enemyCount < _maxEnemyCount)
        {
            if (_timeToSpawn <= 0)
            {
                SpawnEnemy();
                spawnSound.Play();
                _timeToSpawn = _timer;
            }
        }
        _timeToSpawn -= Time.deltaTime;
    }

    private void SpawnEnemy()
    {
        var enemy = Instantiate(_enemyPref, _spawnPoint.transform.position, Quaternion.identity);
        _enemyCount++;
    }
}
