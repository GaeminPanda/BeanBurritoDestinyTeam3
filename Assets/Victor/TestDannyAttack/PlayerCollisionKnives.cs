using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionKnives : MonoBehaviour
{

    public GameObject spawnpoint;
    public GameObject mainPlayer;
    private Rigidbody2D rb2;

    private void Start()
    {
        spawnpoint = GameObject.Find("uhhh");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "enemy")
        {
            Debug.Log("Got herel");
            rb2 = collision.transform.GetComponent<Rigidbody2D>();
            rb2.velocity = new Vector2(0, 0);
            collision.transform.localPosition = spawnpoint.transform.localPosition;
            //SceneManager.LoadScene("CounterTopScene1");

            
        }
    }

}
