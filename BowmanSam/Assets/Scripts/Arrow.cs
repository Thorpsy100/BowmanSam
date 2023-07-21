using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public bool nearMiss = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Near_Miss")
        {
            nearMiss = true;
            Debug.Log("near miss");
        }

        if(other.gameObject.tag == "Boarder")
        {
            Destroy(gameObject);
        }
    }
}
