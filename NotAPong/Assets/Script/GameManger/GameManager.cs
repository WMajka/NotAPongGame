using UnityEngine;
using UnityEngine.InputSystem;


public class GameManager : MonoBehaviour
{
    public RemixComponents GetRemixComponents;
    public Transform[] SpawnPoint;

    public void Awake()
    {
        GetRemixComponents.StartGameCreator();
        Time.timeScale = 1.0f;
    }

    public void PlayBall(InputAction.CallbackContext context)
    {
        if (context.started && !GetRemixComponents.GetBall.activeSelf)
        {
            SetBallAndPlay();
        }
    }

    private void SetBallAndPlay()
    {
        GetRemixComponents.GetBall.SetActive(true);
        GetRemixComponents.GetBall.transform.position = SpawnPoint[UnityEngine.Random.Range(0, 2)].position;
        GetRemixComponents.GetBallRigidbody2D.AddForce(new Vector2(DirectionAndForceForBall(), DirectionAndForceForBall()), ForceMode2D.Impulse);
        
        float DirectionAndForceForBall()
        {
            return GetRemixComponents.DirectionForBall[UnityEngine.Random.Range(0, 2)] * GetRemixComponents.Force;
            
        }
    }
}
