using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private int _enemyHP;
    [SerializeField]
    private int _dealtDamage;


    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
        KilledEnemy();
    }

    private void KilledEnemy()
    {
        if (_enemyHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<PlayerController>();
        var bullet = collision.gameObject.GetComponent<Bullet>();
        
        if (player)
        {
            Destroy(gameObject);
            player.ChangePlayerHealth(_dealtDamage);
        }
        if (bullet)
        {
            Destroy(gameObject);
        }

        Debug.Log(collision.gameObject.name);
    }

    public void TakeDamage(int damage)
    {
        _enemyHP -= damage;

        if (_enemyHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
