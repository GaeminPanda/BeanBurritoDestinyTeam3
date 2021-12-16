using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionKnives : MonoBehaviour
{

    public GameObject spawnpoint;
    public GameObject mainPlayer;
    private Rigidbody2D rb2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TestPlayer")
        {
            rb2 = mainPlayer.GetComponent<Rigidbody2D>();
            rb2.velocity = new Vector2(0, 0);
            mainPlayer.transform.localPosition = spawnpoint.transform.localPosition;
            //SceneManager.LoadScene("EnemiesScene");
        }
    }

}
