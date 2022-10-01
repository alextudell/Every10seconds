using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 speed = new Vector2(5f, 5f);
    
    private Vector2 playerMovement;

    Rigidbody2D player_rb;
    public Animator player_anim;

    void Awake()
    {
        player_rb = GetComponent<Rigidbody2D>();
        // player_anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        playerMovement = new Vector2(
            speed.x * inputX,
            speed.y * inputY);
        
        player_anim.SetFloat("Horizontal", playerMovement.x);
        player_anim.SetFloat("Vertical", playerMovement.y);
        player_anim.SetFloat("Speed", playerMovement.sqrMagnitude);
 
    }

    void FixedUpdate()
    {
        player_rb.velocity = playerMovement;
    }
}
