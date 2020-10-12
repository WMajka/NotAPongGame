using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Points GetPoints;
    public TextMeshProUGUI GetText;
    public GameObject WinScreen;

    private void LateUpdate()
    {
        for (int i = 0; i < GetPoints.PlayerWin.Length; i++)
        {
            if (GetPoints.PlayerWin[i])
            {
                WinScreen.SetActive(true);
                GetText.text = $"Player {i + 1} Wins";
                Time.timeScale = 0.0f;
            }
        }
        
    }

    public void RestartGame()
    {
        var activeScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeScene);
        Time.timeScale = 1.0f;
        WinScreen.SetActive(false);
    }
    
}
