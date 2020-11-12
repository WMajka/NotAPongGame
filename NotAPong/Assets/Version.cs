using TMPro;
using UnityEngine;

public class Version : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI GetText;
    private void Awake()
    {
        GetText.text = $"Version: {Application.version}";
    }
}
