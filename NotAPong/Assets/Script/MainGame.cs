using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGame : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Pong");
    }
   public void ClosePong()
    {
        Application.Quit();
    }
}
