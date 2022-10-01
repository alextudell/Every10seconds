using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField][Range(0.1f, 10)]
    private float _timeToSpawn;
    [SerializeField]
    private GameObject _enemyPref;

    private int _spawnCount;

    private IEnumerator SpawnEnemy(int enemyCount)
    {
        _spawnCount++;

        for (int i = 0; i == enemyCount; i++)
        {
            var enemy = Instantiate(_enemyPref);
            enemy.transform.SetParent(gameObject.transform,false); 
        }

        yield return null;
    }
}
