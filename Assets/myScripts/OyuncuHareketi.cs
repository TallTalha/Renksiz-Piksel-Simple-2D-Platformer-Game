using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuHareketi : MonoBehaviour
{
    public float speed;
    private float move;

    private Rigidbody2D rb2d;

    public float jump;
    public bool isJumpimg;

    private bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector2(speed * move,rb2d.velocity.y);

        if (Input.GetButtonDown("Jump") && isJumpimg==false)
        {
            rb2d.AddForce(new Vector2(rb2d.velocity.x, jump));
        }
    }

    void FixedUpdate()
    {

        if (facingRight == false && move > 0)
        {
            Flip();
        }
        else if (facingRight == true && move < 0)
        {
            Flip();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(isJumpimg);
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumpimg = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log(isJumpimg);
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumpimg = true;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
