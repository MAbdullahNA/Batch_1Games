using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] bool moveRight, moveLeft;
    float moveSpeed = 3f;
    [SerializeField] float jumpForce = 5;
    [SerializeField] Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (moveRight)
        {
            rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocityY);
        }
        if (moveLeft)
        {
            rb.linearVelocity = new Vector2(-moveSpeed, rb.linearVelocityY);
        }
    }
    //
    public void MoveRight()
    {
        moveRight = true;
    }
    public void MoveLeft()
    {
        moveLeft = true;
    }
    public void StopMove()
    {
        moveRight = false;
        moveLeft = false;
    }
    public void Jump()
    {
        if (rb.linearVelocityY == 0)
        {
            rb.AddForce(new Vector2(rb.linearVelocityX, jumpForce));

        }
    }
}
