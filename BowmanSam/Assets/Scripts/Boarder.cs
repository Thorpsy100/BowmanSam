using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boarder : MonoBehaviour
{
    public GameObject arrow;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(GameObject.Find("Arrow_Test(Clone)").GetComponent<Arrow>().nearMiss == false)
        {
            Debug.Log("a");
        }
        else if(GameObject.Find("Arrow_Test(Clone)").GetComponent<Arrow>().nearMiss == true)
        {
            Debug.Log("b");
        }
    }
}
