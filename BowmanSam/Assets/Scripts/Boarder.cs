using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boarder : MonoBehaviour
{
    public GameObject arrow;
    public AudioSource source;
    public AudioClip miss01;
    public AudioClip miss02;
    public AudioClip miss03;
    public AudioClip manHit01;
    public AudioClip manHit02;
    public int missSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Arrow")
        {
            if (GameObject.Find("Arrow_Test(Clone)").GetComponent<Arrow>().nearMiss == false)
            {
                missSound = Random.Range(1, 12);
                if (missSound == 1)
                {
                    source.PlayOneShot(miss01);
                }
                if (missSound == 2)
                {
                    source.PlayOneShot(miss01);
                }
                if (missSound == 3)
                {
                    source.PlayOneShot(miss01);
                }
                if (missSound == 4)
                {
                    source.PlayOneShot(miss02);
                }
                if (missSound == 5)
                {
                    source.PlayOneShot(miss02);
                }
                if (missSound == 6)
                {
                    source.PlayOneShot(miss02);
                }
                if (missSound == 7)
                {
                    source.PlayOneShot(miss03);
                }
                if (missSound == 8)
                {
                    source.PlayOneShot(miss03);
                }
                if (missSound == 9)
                {
                    source.PlayOneShot(miss03);
                }
                if (missSound == 10)
                {
                    source.PlayOneShot(manHit01);
                }
                if (missSound == 11)
                {
                    source.PlayOneShot(manHit02);
                }
            }
        }
        else if(GameObject.Find("Arrow_Test(Clone)").GetComponent<Arrow>().nearMiss == true)
        {
        }
    }
}
