using System.Collections;
using System.Collections.Generic;
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
        viewPos.y = Mathf.Clamp(viewPos.y, -6.6f, 6.6f);
        transform.position = viewPos;
    }
}
