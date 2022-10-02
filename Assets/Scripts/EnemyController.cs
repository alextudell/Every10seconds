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
    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private TimeManager _timeManager;
    private Vector3 _startPoint;

    [SerializeField] 
    private AudioSource _deadSound;

    private GameObject _enemy;
    private bool moving = true;

    private bool _leftDead;
    private bool _rightDead;
    private bool _sharkBoom;
    
    private Bullet bullet;
    


    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        _timeManager = FindObjectOfType<TimeManager>();
        _startPoint = transform.position;
        _enemy = this.gameObject;
    }

    private void FixedUpdate()
    {
        if (moving)
        {
            transform.position = Vector2.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
            if (transform.position.x < _target.position.x)
            {
                _animator.SetTrigger("Right");
                _rightDead = true;
                _leftDead = false;
            }
            if (transform.position.x > _target.position.x)
            {
                _animator.SetTrigger("Left");
                _rightDead = false;
                _leftDead = true;
            }
            KilledEnemy();
        }
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
        bullet = collision.gameObject.GetComponent<Bullet>();

        if (player == null && bullet == null)
        {
            Debug.Log(collision.gameObject.name);
        }
        if (player)
        {
            _sharkBoom = true;
            StartCoroutine(EnemyDeadRoutine());
            player.ChangePlayerHealth(_dealtDamage);
        }
        if (bullet)
        {
            _sharkBoom = false;
            StartCoroutine(EnemyDeadRoutine());
            Destroy(bullet.gameObject);
        }
    }

    public IEnumerator EnemyDeadRoutine()
    {
        if (!_sharkBoom)
        {
            if (_rightDead)
            {
                moving = false;
                _enemy.GetComponent<Collider2D>().enabled = false;
                _animator.SetTrigger("RightDie");
                _deadSound.Play();
                yield return new WaitForSeconds(1);
            }
            if(_leftDead)
            {
                moving = false;
                _enemy.GetComponent<Collider2D>().enabled = false;
                _animator.SetTrigger("LeftDie");
                _deadSound.Play();
                yield return new WaitForSeconds(1);
            }
        }
        else
        {
            if (_rightDead)
            {
                moving = false;
                _enemy.GetComponent<Collider2D>().enabled = false;
                _animator.SetTrigger("RightBoom");
                _deadSound.Play();
                yield return new WaitForSeconds(1);
            }
            if(_leftDead)
            {
                moving = false;
                _enemy.GetComponent<Collider2D>().enabled = false;
                _animator.SetTrigger("LeftBoom");
                _deadSound.Play();
                yield return new WaitForSeconds(1);
            }
        }
        
        Destroy(gameObject);
        _timeManager.GetTimeForKilling();
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
