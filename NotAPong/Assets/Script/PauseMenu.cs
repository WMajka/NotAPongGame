using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
 
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0.0f;
        GameIsPaused = true;
    }
    public void PauseControl(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Pressed Button");
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void LoadMenu()
    {
        Time.timeScale = 1.0f;
        Debug.Log("Menu");
        SceneManager.LoadScene("MainMenu");
    }
    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
