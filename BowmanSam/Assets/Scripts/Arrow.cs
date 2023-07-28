using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public bool nearMiss = false;
    public AudioSource source;
    public AudioClip nearMissSound;
    private Rigidbody2D rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (rigidbody.velocity != Vector2.zero)
        {
            transform.right = rigidbody.velocity;
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Near_Miss")
        {
            nearMiss = true;
            source.PlayOneShot(nearMissSound);

        }

        if(other.gameObject.tag == "Border")
        {
            
            //GameObject.Find("character").GetComponent<ActiveArrow>().activeArrow = false;
            if(nearMiss == false)
            {
            }
            Destroy(gameObject);
            
        }
        if (other.gameObject.tag == "Target")
        {
            Destroy(gameObject);
            //GameObject.Find("character").GetComponent<ActiveArrow>().activeArrow = false;
        }
    }
}
