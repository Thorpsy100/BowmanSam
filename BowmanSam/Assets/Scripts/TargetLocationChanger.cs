using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class TargetLocationChanger : MonoBehaviour
{
    public float xMin = -4.96f;
    public float xMax = 7.83f;
    public float yMin = -3.41f;
    public float yMax = 4.06f;

    public float xPosition;
    public float yPosition;

    public AudioSource source;
    public AudioClip hit01;
    public AudioClip hit02;
    public AudioClip hit03;

    public int hitSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Arrow")
        {
            xPosition = Random.Range(xMin, xMax + .5f);
            //Debug.Log("x value is " + xPosition);
            yPosition = Random.Range(yMin, yMax + .5f);
            //Debug.Log("y value is " + yPosition);
            transform.position = new Vector3(xPosition, yPosition);
            
            hitSound = Random.Range(1, 4);
            Debug.Log("number is" + hitSound);
            if (hitSound == 1)
            {
                source.PlayOneShot(hit01);
            }
            if (hitSound == 2)
            {
                source.PlayOneShot(hit02);
            }
            if (hitSound == 3)
            {
                source.PlayOneShot(hit03);
            }
        }
    }
}
