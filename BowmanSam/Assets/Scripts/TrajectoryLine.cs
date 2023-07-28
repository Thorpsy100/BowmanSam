using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class TrajectoryLine : MonoBehaviour
{
    public LineRenderer lr;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    public void RenderLine(Vector3 startpoint, Vector3 endPoint)
    {
        startpoint.z = 0;
        endPoint.z = 0;
        lr.positionCount = 2;
        Vector3[] points = new Vector3[2];
        points[0] = startpoint;
        points[1] = endPoint;

        lr.SetPositions(points);
    }
}
