using UnityEngine;


public class ControlVector : MonoBehaviour
{


    [SerializeField] private Rigidbody2D ballRigidbody2D;
    public bool changeDirction = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Vector2.Angle(ballRigidbody2D.velocity, collision.contacts[0].normal) <= 15.0f)
        {
            changeDirction = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (changeDirction)
        {
            ballRigidbody2D.AddRelativeForce(ballRigidbody2D.position * 10.0f, ForceMode2D.Force);
            changeDirction = false;
        }
    }
}
