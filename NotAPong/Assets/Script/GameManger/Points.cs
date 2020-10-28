using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Animations;

public class Points : MonoBehaviour
{
    public State GetStateRemix;
    public TextMeshProUGUI[] PlayerTextScore = new TextMeshProUGUI[2];
    [SerializeField] private RemixComponents GetGameMixer;
    public int[] PlayerPoints = new int[2];
    public bool[] PlayerWin = new bool[2];

    private void Awake()
    {
        UpdateTextScore();
    }

    public void AddPoint(int playerNumber)
    {
        PlayerPoints[playerNumber-1]++;
        SetToWin(playerNumber - 1);
        if (GetStateRemix.isActive)
        {
            GetGameMixer.GameRemix(Random.Range(0, 7));
            StartCoroutine(GetGameMixer.ShowText());
        }
    }

    private void LateUpdate()
    {
        UpdateTextScore();
    }

    private void UpdateTextScore()
    {
        PlayerTextScore[0].text = PlayerPoints[0].ToString();
        PlayerTextScore[1].text = PlayerPoints[1].ToString();
    }
    public void SetToWin(int playerNumber)
    {
        if (PlayerPoints[playerNumber] == 5)
        {
            PlayerWin[playerNumber] = true;
        }
    }
}
