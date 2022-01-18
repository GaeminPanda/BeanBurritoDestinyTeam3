using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 15f;
    public float bulletDamage = 10f;
    public Rigidbody2D rb;
    public float damage;

    private void FixedUpdate()
    {
        rb.velocity = Vector2.right * bulletSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;
        if (collisionGameObject.name != "ememy")
        {
            if (collisionGameObject.GetComponent<Health>() != null)
            {
                collisionGameObject.GetComponent<Health>().TakeDamage(damage);
            }
        }
        Destroy(gameObject);
    }
}
