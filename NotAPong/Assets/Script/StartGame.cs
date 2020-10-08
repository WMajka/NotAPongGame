using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms;

public class StartGame : MonoBehaviour
{
    public GameObject GetBall;
    public Transform[] SpawnPoint;
    public Rigidbody2D GetBallRigidbody;
    public float Force = 10.0f;
    public int[] DirectionForBall = { -1, 1};
    private int RandomNumber;

    public void PlayBall(InputAction.CallbackContext context)
    {
        if (context.started && !GetBall.activeSelf)
        {
            RandomNumber = UnityEngine.Random.Range(0, 2);
            GetBall.SetActive(true);
            GetBall.transform.position = SpawnPoint[RandomNumber].position;
            GetBallRigidbody.AddForce(new Vector2(DirectionForBall[UnityEngine.Random.Range(0,2)]* Force, DirectionForBall[UnityEngine.Random.Range(0,2)]* Force), ForceMode2D.Impulse);
        }
    }


}
