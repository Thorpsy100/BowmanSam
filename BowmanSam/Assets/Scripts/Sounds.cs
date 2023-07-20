using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource source;
    public AudioClip pullBack01;
    public AudioClip pullBack02;
    public AudioClip pullBack03;
    public AudioClip fire;

    public int pullBackSound;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pullBackSound = Random.Range(1, 3);
            Debug.Log(pullBackSound);
            if(pullBackSound == 1)
            {
                source.PlayOneShot(pullBack01);
            }
            else if(pullBackSound == 2)
            {
                source.PlayOneShot(pullBack02);
            }
            else if(pullBackSound == 3)
            {
                source.PlayOneShot(pullBack03);
            }
            
        }
        else if (Input.GetMouseButtonUp(0))
        {
            source.PlayOneShot(fire);
        }
    }
}
