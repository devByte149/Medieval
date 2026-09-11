using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController2D : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        // Automatically grab the Rigidbody2D component attached to the Player
        rb = GetComponent<Rigidbody2D>();
        
        // Ensure gravity doesn't pull your top-down character downward
        rb.gravityScale = 0f; 
    }

    void Update()
    {
        // GetRawAxis gives crisp stops and starts without the "ice-skating" slide effect
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Normalizing ensures diagonal movement isn't faster than moving straight
        movement = movement.normalized;
        Debug.Log("movement:" + movement);
        Debug.Log("input:" + Input.inputString);
    }

    void FixedUpdate()
    {
        // Apply the movement to the physics body during the physics step
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}