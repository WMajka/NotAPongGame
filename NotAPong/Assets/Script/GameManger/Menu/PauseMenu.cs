using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    private static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    [SerializeField] private State GetStateForPostProccesing;

    public void PauseControl(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (GameIsPaused)
            {
                PauseStatus(false, 1.0f);
            }
            else
            {
                PauseStatus(true, 0.0f);
            }
        }
    }
    public void PauseStatus(bool isPaused, float TimeScale)
    {
        PauseMenuUI.SetActive(isPaused);
        Time.timeScale = TimeScale;
        GameIsPaused = isPaused;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainMenu");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void PostprocessingToggle()
    {
        GetStateForPostProccesing.isActive = !GetStateForPostProccesing.isActive;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
        PauseMenuUI.SetActive(false);
        GameIsPaused = false;
    }
}
