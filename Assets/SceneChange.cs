using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TestPlayer")
        {
            Debug.Log("Switch Scene");
            SceneManager.LoadScene("EndComic");
        }
    }
}
