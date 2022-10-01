using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject managersHandler;
    private GameObject gunObject;
    
    public Vector2 speed = new Vector2(5f, 5f);
    
    private Vector2 playerMovement;
    private Vector2 movementDirection;

    private float inputX;
    private float inputY;

    private UIManager uiManager;
    private int playerHealth;
    private int lastHorizontalDir;

    Rigidbody2D player_rb;
    public Animator player_anim;

    void Awake()
    {
        uiManager = managersHandler.GetComponent<UIManager>();

        player_rb = GetComponent<Rigidbody2D>();
        gunObject = transform.GetChild(0).gameObject;
        playerHealth = 2;
        player_anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

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

    public void ChangePlayerHealth(int deltaHealth)
    {
        playerHealth -= deltaHealth;
        uiManager.ChangeUIHealth(playerHealth);

        if (playerHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
