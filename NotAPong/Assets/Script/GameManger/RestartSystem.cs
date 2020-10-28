using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartSystem : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadSceneAsync("Pong");
        Time.timeScale = 1.0f;
    }
}
