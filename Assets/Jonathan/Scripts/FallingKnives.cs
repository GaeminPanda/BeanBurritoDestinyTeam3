using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingKnives : MonoBehaviour
{
    Rigidbody2D rb2;
    BoxCollider2D boxCollider2d;
    public float distance;
    bool isFalling = false;

    private void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        boxCollider2d = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        Physics2D.queriesStartInColliders = false;
        if(isFalling == false)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distance);

            Debug.DrawRay(transform.position, Vector2.down * distance, Color.red);

            if(hit.transform != null)
            {
                if(hit.transform.tag == "TestPlayer")
                {
                    rb2.gravityScale = 5;
                    isFalling = true;
                }
            }
        }
    }
}
