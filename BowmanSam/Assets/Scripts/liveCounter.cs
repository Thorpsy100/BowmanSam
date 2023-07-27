using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liveCounter : MonoBehaviour
{
    public int liveCount;
    public Lives live;

    private void Update()
    {
        liveCount = live.numOfHearts;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Arrow")
            Debug.Log("executing");
            live.numOfHearts = live.numOfHearts - 1;
    }
}
