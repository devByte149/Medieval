using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController2D : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        // Gets rigidbody component and sets gravity scaling to 0 since game is top-down
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        // Main movement logic -- TODO: Move to main logic loop later
        transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * moveSpeed * Time.deltaTime;
    }

    void FixedUpdate()
    {
    }
}