using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGameMenu : MonoBehaviour
{
    public void Start2PlayerGame()
    {
        SceneManager.LoadScene("Pong");
    }
    public void StartAIGame()
    {
        SceneManager.LoadScene("AIPong");
    }
   public void ClosePong()
    {
        Application.Quit();
    }
}
