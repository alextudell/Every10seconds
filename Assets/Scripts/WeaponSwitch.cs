using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{

    [SerializeField] 
    private GameObject _gun;
    [SerializeField] 
    private GameObject _knife;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if (_gun.activeInHierarchy)
            {
                _gun.SetActive(false);
                _knife.SetActive(true);
            }

            if (_knife.activeInHierarchy)
            {
                _gun.SetActive(true);
                _knife.SetActive(false);
            }
        }
    }
}
