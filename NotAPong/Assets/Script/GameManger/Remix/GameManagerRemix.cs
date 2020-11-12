using UnityEngine;

public class GameManagerRemix : MonoBehaviour
{
    [SerializeField] private RemixComponents GetRemix;
    [SerializeField] private GameObject GetRemixObject;
    public State GetRemixState;

    void DoTheRemix()
    {
        GetRemix.GameRemix(Random.Range(1, 8));
        StartCoroutine(GetRemix.ShowText());
    }

    private void Start()
    {
        if (GetRemixState.isActive)
        {
            InvokeRepeating("DoTheRemix", 10.0f, 15.0f);
        }
    }


}
