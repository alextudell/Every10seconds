using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] private Transform _attackPoint;
    [SerializeField] private LayerMask _damageableLayerMask;
    [SerializeField] private int _damage;
    [SerializeField] private float _attackRange;
    [SerializeField] private float _timeBtwAttack;
    [SerializeField] private Animator _animator;

    private float _timer;

    private void Update()
    {
        Attack();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_attackPoint.position, _attackRange);
    }

    public void Attack()
    {
        if (_timer <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                Collider2D[] enemies =
                    Physics2D.OverlapCircleAll(_attackPoint.position, _attackRange, _damageableLayerMask);

                if (enemies.Length != 0)
                {
                    for( int i = 0; i < enemies.Length; i++)
                    {
                        enemies[i].gameObject.GetComponent<EnemyController>().TakeDamage(_damage);
                    }
                }
                
            }
            _timer = _timeBtwAttack;
        }
        else
        {
            _timer -= Time.deltaTime;
        }
    }

}
