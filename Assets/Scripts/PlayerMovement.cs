using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 speed = new Vector2(5f, 5f);
    
    private Vector2 playerMovement;

    Rigidbody2D player_rb;

    void Awake()
    {
        player_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        playerMovement = new Vector2(
            speed.x * inputX,
            speed.y * inputY);
 
    }

    void FixedUpdate()
    {
        player_rb.velocity = playerMovement;
    }
}
