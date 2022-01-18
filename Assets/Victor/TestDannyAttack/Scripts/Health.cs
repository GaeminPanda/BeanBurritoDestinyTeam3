using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float startHealth;
    private float hp;

    public GameObject dieEffect;
    void Start()
    {
        hp = startHealth;
    }

   
    void Update()
    {
        
    }
    public void TakeDamage (float damage)
    {
        hp -= damage;
        if (hp <= 0f)
        {
            //Die();
        }
    }
    void Die()
    {
        if(dieEffect != null)
        {
            Instantiate(dieEffect, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
