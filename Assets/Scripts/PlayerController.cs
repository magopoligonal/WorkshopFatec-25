using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //parametros
    public float speed = 5f;
    public float jumpForce = 10f;
    private bool _isGrounded = false;

    //componentes
    public Rigidbody2D rigidBody;
    public LayerMask groundLayer;
    public Animator animator;
    private SpriteRenderer _spriteRenderer;
    

    public bool IsGrounded { get => _isGrounded; set => _isGrounded = value; }

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        movement();
    }

    private void movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        //horizontal moveHorizontal
        if (moveHorizontal != 0)
        {
            rigidBody.linearVelocity = new Vector2(moveHorizontal * speed, rigidBody.linearVelocity.y);
            animator.SetBool("Walking", true);
            if (moveHorizontal > 0)
            {
                _spriteRenderer.flipX = false;
            }
            else if(moveHorizontal < 0)
            {
                _spriteRenderer.flipX = true;
            }
        }
        else
        {
            animator.SetBool("Walking", false);
        }


        //JUMP
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            rigidBody.AddForceY(jumpForce);
            IsGrounded = false;
        }
    }
    


    //colliders
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            IsGrounded = true;
        }
    }
}
