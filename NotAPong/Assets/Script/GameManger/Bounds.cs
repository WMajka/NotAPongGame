using UnityEngine;

public class Bounds : MonoBehaviour
{
    private void LateUpdate()
    {
        PlayerBounds();
    }

    private void PlayerBounds()
    {
        Vector2 viewPos = transform.position;
        viewPos.y = Mathf.Clamp(viewPos.y, -10.7f, 10.7f);
        transform.position = viewPos;
    }
}
