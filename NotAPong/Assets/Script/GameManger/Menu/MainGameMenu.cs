using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Rendering;

public class MainGameMenu : MonoBehaviour
{

    [SerializeField] State GetStateForAi;
    [SerializeField] State GetStateRemixMode;
    [SerializeField] State GetStateForPostProccesing;
    [SerializeField] TextMeshProUGUI GetPostproccesingText;
    [SerializeField] TextMeshProUGUI GetRemixText;
    [SerializeField] GameObject GetTitleRemixText;
    [SerializeField] AudioSource GetClipAudio;
    [SerializeField] Volume PostProces;
    [SerializeField] private string RemixString;
    [SerializeField] private string PostprocessingString;

    public void Awake()
    {
        GetStateRemixMode.isActive = false;
        PostProces.enabled = GetStateForPostProccesing.isActive;
        GetTitleRemixText.SetActive(false);
    }
    public void Start()
    {
        if (GetStateForPostProccesing.isActive)
        {
            GetPostproccesingText.text = $"{PostprocessingString} ON";
        }
        else
        {
            GetPostproccesingText.text = $"{PostprocessingString} OFF";
        }
        if (GetStateRemixMode.isActive)
        {
            GetRemixText.text = $"{RemixString} on";
        }
        else
        {
            GetRemixText.text = $"{RemixString} Off";
        }
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
    public void RemixModeToggle()
    {
        PlayAudio();
        GetStateRemixMode.isActive = !GetStateRemixMode.isActive;
        if (GetStateRemixMode.isActive)
        {
            GetRemixText.text = $"{RemixString} On";
            GetTitleRemixText.SetActive(true);
        }
        else
        {
            GetRemixText.text = $"{RemixString} Off";
            GetTitleRemixText.SetActive(false);
        }
    }
    public void PostprocessingToggle()
    {
        PlayAudio();
        GetStateForPostProccesing.isActive = !GetStateForPostProccesing.isActive;
        PostProces.enabled = GetStateForPostProccesing.isActive;
        if (GetStateForPostProccesing.isActive)
        {
            GetPostproccesingText.text = $"{PostprocessingString} ON";
        }
        else
        {
            GetPostproccesingText.text = $"{PostprocessingString} OFF";
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
