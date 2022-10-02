using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private GameObject doorArrow;
    public bool isCracked;
    [SerializeField] private Animator doorAnimator;


    void Start()
    {

        doorArrow = transform.GetChild (0).gameObject;
        isCracked = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (isCracked) 
        {
            doorAnimator.SetBool("doorOpened", true);
            doorArrow.SetActive(true);
        }
    }
}
