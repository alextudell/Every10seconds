using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private GameObject doorArrow;
    public bool isCracked;
    private Animator doorAnimator;


    void Start()
    {
        doorAnimator = GetComponent<Animator>();

        doorArrow = transform.GetChild (0).gameObject;
        isCracked = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (isCracked) 
        {
            doorArrow.SetActive(true);
        }
    }
}
