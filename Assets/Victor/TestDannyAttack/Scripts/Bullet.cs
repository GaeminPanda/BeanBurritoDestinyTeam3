using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 15f;
    public Rigidbody2D rb;
    public int damage = 5;
    

    private void FixedUpdate()
    {
        rb.velocity = Vector2.right * bulletSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyHP enemy = hitInfo.GetComponent<EnemyHP>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}