using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Points GetPoints;
    public TextMeshProUGUI GetText;
    public GameObject WinScreen;
    public AudioSource GetAudio;

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

    public void GoBackToMenu()
    {
        GetAudio.Play();
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainMenu");
        WinScreen.SetActive(false);
    }
    
}
