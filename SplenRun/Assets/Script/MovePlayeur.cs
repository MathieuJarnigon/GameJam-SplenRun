using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayeur : MonoBehaviour
{
    private float horizontal;
    [SerializeField] private float speed;
    public float jumpingPower;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if ( Input.GetKeyDown(KeyCode.Z) && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0, jumpingPower), ForceMode2D.Impulse);
        }

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Blue_plaque")
        {
            speed = 15f;
        }
        if (collision.gameObject.tag == "Green_plaque")
        {
            jumpingPower = 20f;
        }
        if (collision.gameObject.tag == "Red_plaque")
        {
            speed = 8f;
            jumpingPower = 16f;
        }
    }
}
