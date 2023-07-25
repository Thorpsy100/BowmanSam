using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocationChanger : MonoBehaviour
{
    public float xMin = -5.25f;
    public float xMax = 8.4f;
    public float yMin = -3.6f;
    public float yMax = 4.5f;

    public float xPosition;
    public float yPosition;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Arrow")
        {
            xPosition = Random.Range(xMin, xMax + 1);
            Debug.Log("x value is " + xPosition);
            yPosition = Random.Range(yMin, yMax + 1);
            Debug.Log("y value is " + yPosition);
            transform.position = new Vector3(xPosition, yPosition);
        }
    }
}
