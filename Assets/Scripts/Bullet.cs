using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] 
    private float _speed;

    [SerializeField] 
    private float _destroyTime;

    private void Start()
    {
        Invoke("DestroyBullet", _destroyTime);
    }

    void Update()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime);
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.gameObject.GetComponent<EnemyController>();
        
        
        if (!enemy)
        {
            Destroy(gameObject);
        }
        Debug.Log(collision.gameObject.name);
    }
}
