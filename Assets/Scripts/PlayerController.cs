using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float speed = 5f;
    public float jumpForce = 10f;
    private bool _isGrounded = false;
    public LayerMask groundLayer;
   

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement();
    }

    private void movement()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            rigidBody.linearVelocity =
                new Vector2(Input.GetAxis("Horizontal") * speed,
                    rigidBody.linearVelocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            rigidBody.AddForceY(jumpForce);
            _isGrounded = false;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        _isGrounded = true;
    }
}
