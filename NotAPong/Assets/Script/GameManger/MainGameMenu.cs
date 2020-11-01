﻿using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainGameMenu : MonoBehaviour
{

    [SerializeField] State GetStateForAi;
    [SerializeField] State GetStateRemixMode;
    [SerializeField] State GetStateForPostProccesing;
    [SerializeField] TextMeshProUGUI GetPostproccesingText;
    [SerializeField] TextMeshProUGUI GetRemixText;
    [SerializeField] GameObject GetTitleRemixText;
    [SerializeField] AudioSource GetClipAudio;
    [SerializeField] private string RemixString;
    [SerializeField] private string PostprocessingString;

    public void Awake()
    {
        GetStateRemixMode.isActive = false;
        GetStateForPostProccesing.isActive = true;
        GetPostproccesingText.text = $"{PostprocessingString} ON";
        GetRemixText.text = $"{RemixString} Off";
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
