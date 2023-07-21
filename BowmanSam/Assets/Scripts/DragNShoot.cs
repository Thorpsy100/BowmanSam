using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DragNShoot : MonoBehaviour
{
    public float power = 10f;
    Rigidbody2D rb;

    public Vector2 minPower;
    public Vector2 maxPower;

    public TrajectoryLine tl;

    public float waitTime = 2.0f;
    float timer;

    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;

    private void Start()
    {
        cam = Camera.main;
        tl = GetComponent<TrajectoryLine>();
        rb = GetComponent<Rigidbody2D>();

        if (Input.GetMouseButtonDown(0))
        {
            startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            startPoint.z = 15;
        }
    }

    private void Update()
    {
        float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);



        if(Input.GetMouseButton(0))
        {
            //Debug.Log(startPoint);
            Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            currentPoint.z = 15;
            tl.RenderLine(startPoint, currentPoint);
            rb.isKinematic = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            rb.isKinematic = false;
            endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            endPoint.z = 15;
            //Debug.Log(endPoint);

            force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
            rb.AddForce(force * power, ForceMode2D.Impulse);

        }

        

    }
}
