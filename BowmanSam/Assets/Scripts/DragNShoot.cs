using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class DragNShoot : MonoBehaviour
{
    public float power = 10f;

    public float minPower;
    public float maxPower;

    public TrajectoryLine tl;

    public float waitTime = 2.0f;
    float timer;

    Camera cam;
    public Vector2 force;
    public Vector3 startPoint;
    Vector3 endPoint;
    public Vector3 currentPoint;

    public Vector2 distance;


    public GameObject arrowPrefab;
    public Transform shotPoint;
    public GameObject arrowActive;
    private Rigidbody2D arrowRb;

    private void Start()
    {
        cam = Camera.main;
        tl = GetComponent<TrajectoryLine>();

    }

    private void Update()
    {
        // Arrow manual rotation
        //float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        

        // Mouse down
        if (Input.GetMouseButtonDown(0))
        {
            startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            arrowActive = Instantiate(arrowPrefab, shotPoint.position, shotPoint.rotation);
            tl.lr.enabled = true;
            arrowActive.transform.parent = transform;
        }

        if (arrowActive == null)
        {
            return;
        }

        // Mouse hold
        if (Input.GetMouseButton(0))
        {

            currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            tl.RenderLine(startPoint, currentPoint);
            arrowActive.GetComponent<Rigidbody2D>().gravityScale = 0;

            endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            endPoint.z = 15;
            //Debug.Log(endPoint);

            distance = startPoint - endPoint;

            //TODO:
            //if (GameObject.Find("character").GetComponent<ActiveArrow>().activeArrow == false)
            //{
            //    //Debug.Log(startPoint);

            //    currentPoint.z = 15;
            //    rb.isKinematic = true;
            //}
        }

        // Mouse up
        if (Input.GetMouseButtonUp(0))
        {
            //TODO:
            //if (GameObject.Find("character").GetComponent<ActiveArrow>().activeArrow == false)
            //{
            arrowActive.GetComponent<Rigidbody2D>().isKinematic = false;


            float magnitude = Mathf.Clamp(distance.magnitude, minPower, maxPower);
            
            force = distance.normalized * magnitude;



            //force = new Vector2(Mathf.Clamp(distance.x, minPower.x, maxPower.x), Mathf.Clamp(distance.y, minPower.y, maxPower.y));



            Debug.Log("Arrow Shot");
            arrowActive.GetComponent<Rigidbody2D>().AddForce(force * power, ForceMode2D.Impulse);
            arrowActive.GetComponent<Rigidbody2D>().gravityScale = 1;


            arrowActive.transform.parent = null;
            tl.lr.enabled = false;
            //GameObject.Find("character").GetComponent<ActiveArrow>().activeArrow = true;
            
            
            //}
        }
    }
}
