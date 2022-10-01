using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;

    [SerializeField] 
    private Transform _shotDir;

    private float _timeShot;
    [SerializeField] 
    private float _startTime;
    void Update()
    {
        if (_timeShot <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(_bullet, _shotDir.position, transform.rotation);
                _timeShot = _startTime;
            }
        }
        else
        {
            _timeShot -= Time.deltaTime;
        }
    }
}
