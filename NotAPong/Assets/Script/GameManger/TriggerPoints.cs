using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPoints : MonoBehaviour
{
    public Points GetPoints;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Point"))
        {
            GetPoints.AddPoint(1);
        }
        if (collision.CompareTag("Point2"))
        {
            GetPoints.AddPoint(2);
        }
        gameObject.SetActive(false);
    }
}
