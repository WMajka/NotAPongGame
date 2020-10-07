using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    public TextMeshProUGUI[] PlayerScoring;
    public int[] playerPoints; 

    private void Awake()
    {
        PlayerScoring[0].text = playerPoints[0].ToString();
        PlayerScoring[1].text = playerPoints[1].ToString();

    }

    public void AddPoint(int playerNumber)
    {
        playerPoints[playerNumber-1]++;
    }

    private void LateUpdate()
    {
        PlayerScoring[0].text = playerPoints[0].ToString();
        PlayerScoring[1].text = playerPoints[1].ToString();

    }
}
