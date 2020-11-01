using System.Collections;
using UnityEngine;
using TMPro;

[CreateAssetMenu]
public class RemixComponents : ScriptableObject
{

    public State GetStateForRemix;
    [SerializeField] internal GameObject[] GetPad = new GameObject[2];
    [SerializeField] internal GameObject GetBall;
    [SerializeField] internal Rigidbody2D GetBallRigidbody2D;
    [SerializeField] internal GameObject GetCamera;
    [SerializeField] private GameObject GetRemixTextObject;
    private Material[] GetMaterials = new Material[2];
    private TextMeshProUGUI GetRemixText;
    [SerializeField] public  bool ReversedControl { get; private set; }
    [SerializeField] public float PlayerSpeed { get; private set; }
    [SerializeField] public float Force { get; private set; }
    [SerializeField] public int[] DirectionForBall { get;  } = { -1, 1 };
    public int[] CameraAngles { get; } = { 0, 180 };
    public string NameForRule { get; set; }
    public void StartGameCreator()
    {
        GetPad = GameObject.FindGameObjectsWithTag("Player");
        GetMaterials[0] = GetPad[0].GetComponent<SpriteRenderer>().material;
        GetMaterials[1] = GetPad[1].GetComponent<SpriteRenderer>().material;
        GetRemixTextObject = GameObject.FindGameObjectWithTag("Remix");
        GetRemixText = GetRemixTextObject.GetComponent<TextMeshProUGUI>();
        GetRemixTextObject.SetActive(false);
        GetBall = GameObject.Find("Ball");
        GetCamera = GameObject.Find("Main Camera");
        GetBall.SetActive(false);
        GetBallRigidbody2D = GetBall.gameObject.GetComponent<Rigidbody2D>();
        PlayerSpeed = 10.0f;
        Force = 10.0f;

    }
    public void GameRemix(int PickupNumber)
    {
        
            switch (PickupNumber)
            {
            case 0:
                ChangeForceForBallAtStart();
                break;
            case 1:
                ChangePlayerSpeed();
                break;
            case 2:
                BallScale();
                break;
            case 3:
                ChangePadSize();
                break;
            case 4:

                InverseSpeedPlayer();
                break;
            case 5:
                UpIsDown();
                break;
            case 6:
                CloakPads();
                break;
            case 7:
                ChangeBallSpeed();
                break;
            }
    }

    private void ChangeForceForBallAtStart()
    {
        NameForRule = "More Force at start";
        Force = Random.Range(10, 20);
    }

    private void ChangePlayerSpeed()
    {
        NameForRule = "Player Speed";
        PlayerSpeed = Random.Range(7, 25);
    }

    private void BallScale()
    {
        NameForRule = "Ball Remix";
        float scaleForBall = Random.Range(0.01f, 2.5f);
        GetBall.transform.localScale = new Vector2(scaleForBall, scaleForBall);
    }

    private void ChangePadSize()
    {
        NameForRule = "Pads Size Remix";
        foreach (var Pad in GetPad)
        {
            Pad.transform.localScale = new Vector2(Random.Range(0.5f, 3.0f), Random.Range(1.0f, 3.0f));
        }
    }

    private void InverseSpeedPlayer()
    {
        NameForRule = "Inverse Speed";
        PlayerSpeed *= -1;
    }

    private void UpIsDown()
    {
        NameForRule = "Up is Down??";
        GetCamera.transform.Rotate(new Vector3(0.0f, 0.0f, CameraAngles[Random.Range(0, 2)]));
    }

    private void CloakPads()
    {
        NameForRule = "Wait, where is my Pad?";
        GetMaterials[0].SetFloat("_Fade", Random.Range(0.2f, 1.0f));
        GetMaterials[1].SetFloat("_Fade", Random.Range(0.2f, 1.0f));
    }
    private void ChangeBallSpeed()
    {
        NameForRule = "So Fasst Ball!";
        GetBallRigidbody2D.velocity *= Random.Range(0.5f, 1.35f);
    }
    public IEnumerator ShowText()
    {
        GetRemixText.text = NameForRule;
        GetRemixTextObject.SetActive(true);
        yield return new WaitForSecondsRealtime(1.0f);
        GetRemixTextObject.SetActive(false);
    }


}
