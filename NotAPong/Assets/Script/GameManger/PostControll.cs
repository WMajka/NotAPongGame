using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PostControll : MonoBehaviour
{
    [SerializeField] private State GetStateForPostProccesing;
    [SerializeField] private Volume GetVolume;
    private void Awake()
    {
        GetVolume.enabled = GetStateForPostProccesing.isActive;

    }

    public void EnablePost()
    {
        GetVolume.enabled = !GetVolume.enabled;
        GetStateForPostProccesing.isActive = GetVolume.enabled;
    }
}
