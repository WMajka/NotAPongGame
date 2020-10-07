using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Transform GetPlayerTransform;
    [SerializeField] private PlayerInput GetPlayerInput;
    [SerializeField] private BasicValues GetBasicValues;

    private void Move()
    {
        GetPlayerTransform.transform.Translate(new Vector2(0.0f, GetPlayerInput.moveHorizontal * GetBasicValues.PlayerSpeed * Time.deltaTime));
    }
    private void FixedUpdate()
    {
        Move();
    }
}
