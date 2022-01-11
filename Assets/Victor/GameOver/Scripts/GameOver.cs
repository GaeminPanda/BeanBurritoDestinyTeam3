using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void LoadNextThing()
    {
        SceneManager.LoadScene("CounterTopScene1");
    }
    public void LoadNextThing2()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
