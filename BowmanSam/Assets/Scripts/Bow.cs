using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public GameObject arrow;
    public float launchForce;
    public Transform shotPoint;

    private void Update()
    {

        Vector2 bowPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - bowPosition;
        transform.right = direction;

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    


    void Shoot()
    {
        GameObject newArrow = Instantiate(arrow, shotPoint.position, shotPoint.rotation);
        if (Input.GetMouseButton(0))
        {
            newArrow.transform.position = shotPoint.position;
            newArrow.transform.rotation = shotPoint.rotation;
        }
        //newArrow.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
    }
}
