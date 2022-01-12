using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanBullet : MonoBehaviour
{
    public float speed;
    public float lifetime;

    public GameObject destroyEffect;

    private void Start()
    {
        Invoke("destroyprojectile", lifetime); 
    }

    private void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
    }

    void Destroyprojectile()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
