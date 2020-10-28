
using UnityEngine;

public class EnemyAi : MonoBehaviour
{

    public Transform GetBallTransform;
    public Rigidbody2D GetAIRigidbody2D;
    public GameManager GetGameManager;


    // Update is called once per frame
    void FixedUpdate()
    {
        //gameObject.transform.localPosition = Vector2.MoveTowards(new Vector2(-19.0f, gameObject.transform.localPosition.y), new Vector2(0.0f, GetBallTransform.transform.position.y), GetGameManager.GetRemixComponents.PlayerSpeed * Time.deltaTime * 5);
        GetAIRigidbody2D.MovePosition(new Vector2(0.0f, GetBallTransform.position.y * Time.deltaTime * GetGameManager.GetRemixComponents.PlayerSpeed * 5.5f));
    
    }
}
