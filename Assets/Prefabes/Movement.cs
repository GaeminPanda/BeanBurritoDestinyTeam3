using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float jumpCut = 0.5f;
    public LayerMask ground;
    [SerializeField]
    private float jumpPower = 1f;
    private float horizontal;
    [SerializeField]
    private float moveSpeed = 1f;
    Rigidbody2D rb2;
    Animator a;
    [HideInInspector]public bool isFacingRight=true;

    private Vector3 respawnPoint;
    public GameObject fallDetector;

    private int score = 0;

    private bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        a = gameObject.GetComponent<Animator>();
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        a.SetFloat("yVelocity", rb2.velocity.y);
        a.SetBool("Grounded", IsGrounded());


        horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal == 0)
        {
            a.SetBool("Moving", false);
            isFacingRight = false;
        }
        else
        {
            a.SetBool("Moving", true);
            isFacingRight = true;
        }

        if (Input.GetButtonDown("Jump") && IsGrounded() == true) //Jump Function
        {
            rb2.velocity = new Vector2(rb2.velocity.x, jumpPower);
        }

        Flip();
        if (Input.GetButtonUp("Jump"))
        {
            if(rb2.velocity.y > 0)
            {
                rb2.velocity = new Vector2(rb2.velocity.x, rb2.velocity.y * jumpCut);
            }
        }

        fallDetector.transform.position = new Vector2(transform.position.x, fallDetector.transform.position.y);

    }

    private void Flip()
    {
        if (facingRight && horizontal < 0f || !facingRight && horizontal > 0f)
        {
            Vector3 localScale = transform.localScale;
            facingRight = !facingRight;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void FixedUpdate()
    {
        rb2.velocity = new Vector2(horizontal * moveSpeed, rb2.velocity.y);//Basic Movement
    }

    public bool IsGrounded()
    {
        bool grounded = Physics2D.BoxCast(transform.position + new Vector3(0f, 0f, 0f), new Vector3(0.1f, 1f, 0f), 0, Vector2.down, 0.7f, ground);

        return grounded;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "FallDetector")
        {
            transform.position = respawnPoint;
        }
       else if(collision.tag == "CheckPoint")
        {
            respawnPoint = transform.position;
        }
       else if (collision.tag == "Bean")
        {
            score += 1;
            Debug.Log(score);
            collision.gameObject.SetActive(false);
        }

    }

}
