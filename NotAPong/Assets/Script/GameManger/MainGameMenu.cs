using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainGameMenu : MonoBehaviour
{

    [SerializeField] State GetStateForAi;
    [SerializeField] State RemixMode;
    [SerializeField] TextMeshProUGUI GetRemixText;
    [SerializeField] GameObject GetTitleRemixText;
    [SerializeField] AudioSource GetClipAudio;
    [SerializeField] private string RemixText;

    public void Awake()
    {
        RemixMode.isActive = false;
        GetRemixText.text = $"{RemixText} Off";
        GetTitleRemixText.SetActive(false);
    }
    public void Start2PlayerGame()
    {
        PlayAudio();
        SceneManager.LoadScene("Pong");
        GetStateForAi.isActive = false;

    }
    public void StartAIGame()
    {
        PlayAudio();
        SceneManager.LoadScene("Pong");
        GetStateForAi.isActive = true;
    }
    public void RemixModeToogle()
    {
        PlayAudio();
        RemixMode.isActive = !RemixMode.isActive;
        if (RemixMode.isActive)
        {
            GetRemixText.text = $"{RemixText} On";
            GetTitleRemixText.SetActive(true);
        }
        else
        {
            GetRemixText.text = $"{RemixText} Off";
            GetTitleRemixText.SetActive(false);
        }
    }
    public void ClosePong()
    {
        PlayAudio();
        Application.Quit();
    }
    public void PlayAudio()
    {
        GetClipAudio.Play();
    }
}
