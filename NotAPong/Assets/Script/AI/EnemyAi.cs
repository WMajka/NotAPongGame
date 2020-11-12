using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public Transform GetBallTransform;
    public float DifficultyValue;


    void FixedUpdate()
    {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, new Vector2(gameObject.transform.position.x, GetBallTransform.position.y), DifficultyValue * Time.deltaTime);
    }
}
