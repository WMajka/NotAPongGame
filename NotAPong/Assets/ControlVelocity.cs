using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlVelocity : MonoBehaviour
{
    [SerializeField] private Rigidbody2D GetBallRigidbody2D;

    private void FixedUpdate()
    {
        if (GetBallRigidbody2D.velocity.magnitude < 15.0f)
        {
            GetBallRigidbody2D.AddForce(GetBallRigidbody2D.velocity * 1.25f, ForceMode2D.Force);
        }
        if (GetBallRigidbody2D.velocity.magnitude > 25.0f)
        {
            GetBallRigidbody2D.velocity *= 0.75f;
        }

    }
}
