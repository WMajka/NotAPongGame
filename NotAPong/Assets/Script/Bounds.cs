using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{

    private void LateUpdate()
    {
        Vector2 viewPos = transform.position;
        viewPos.y = Mathf.Clamp(viewPos.y, -6.3f,6.3f);
        transform.position = viewPos;
    }
}
