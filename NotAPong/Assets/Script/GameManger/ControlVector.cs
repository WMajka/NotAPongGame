using UnityEngine;


public class ControlVector : MonoBehaviour
{


    [SerializeField] private Rigidbody2D ballRigidbody2D;
    public bool changeDirection = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Vector2.Angle(ballRigidbody2D.velocity, collision.contacts[0].normal) <= 15.0f)
        {
            changeDirection = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (changeDirection)
        {
            ballRigidbody2D.AddRelativeForce(ballRigidbody2D.position * 15.0f, ForceMode2D.Force);
            changeDirection = false;
        }
    }
}
