using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanBullet : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;
    public LayerMask whatIsSolid;

    public GameObject destroyEffect;

    private void Start()
    {
        Invoke("destroyprojectile", lifetime); 
    }

    private void Update()
    {

        RaycastHit hitinfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitinfo.collider != null)
        {
            if (hitinfo.collider.CompareTag("Enemy"))
            {
                Debug.Log("ENEMY MUST TAKE DAMAGE !");
            }
            Destroyprojectile();
        }

        transform.Translate(transform.up * speed * Time.deltaTime);
    }

    void Destroyprojectile()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
