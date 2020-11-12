using UnityEngine;

public class SetAi : MonoBehaviour
{
    [SerializeField] private State GetStateForAi;

    private void Start()
    {
        EnableAi(GetStateForAi.isActive);
    }

    private void EnableAi(bool StateForEnemyAI)
    {
        gameObject.GetComponent<PlayerMove>().enabled = !StateForEnemyAI;
        gameObject.GetComponent<EnemyAi>().enabled = StateForEnemyAI;
    }
}
