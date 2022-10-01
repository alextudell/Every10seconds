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
        var targetPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var lookVector = targetPoint - transform.position;
        var normalizedLookVector = lookVector.normalized;
        var rot = transform.localRotation;
        var rotEuler = rot.eulerAngles;
        rotEuler.x = 0;
        rotEuler.y = 0;
        //var tan = normalizedLookVector.y / normalizedLookVector.x;
        rotEuler.z = Mathf.Atan2(normalizedLookVector.y, normalizedLookVector.x) * Mathf.Rad2Deg;
        rot.eulerAngles = rotEuler;
        //rot.SetLookRotation(lookVector);
        //targetPoint.z = 0;
        //var tp = new Vector3(targetPoint.x, 0, targetPoint.y);
        transform.localRotation = rot;
        

        if (_timeShot <= 0)
        {
            // СДЕЛАТЬ ПРОВЕРКУ НА gamePaused в pausedManager
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
