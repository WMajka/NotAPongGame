
using UnityEngine;

public class EnemyAi : MonoBehaviour
{

    public Transform GetBallTransform;
    public Rigidbody2D GetAIRigidbody2D;
    public GameManager GetGameManager;


    // Update is called once per frame
    void FixedUpdate()
    {
        //GetAiTransform.transform.localPosition = Vector2.MoveTowards(new Vector2(-13.0f, GetAiTransform.transform.localPosition.y), new Vector2(0.0f, GetBallTransform.transform.position.y), GetGameManager.PlayerSpeed * Time.deltaTime * 2);
        GetAIRigidbody2D.MovePosition(new Vector2(-13.0f, GetBallTransform.position.y * Time.deltaTime * GetGameManager.PlayerSpeed * 7));
    
    }
}
