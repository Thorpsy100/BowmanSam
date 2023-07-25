using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public bool nearMiss = false;
    public AudioSource source;
    public AudioClip nearMissSound;
    public AudioClip farMissSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Near_Miss")
        {
            nearMiss = true;
            source.PlayOneShot(nearMissSound);

        }

        if(other.gameObject.tag == "Boarder")
        {
            Destroy(gameObject);
            if(nearMiss == false)
            {
                source.PlayOneShot(farMissSound);
            }
            
        }
    }
}
