using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] wayPoints;
    private int currentWayPointIndex = 0;
    [SerializeField] private float speed = 2f;
    
    private void Update()
    {
        if (Vector2.Distance(wayPoints[currentWayPointIndex].transform.position, transform.position) < 0.1f) {
            currentWayPointIndex++;
            if(currentWayPointIndex >= wayPoints.Length) { currentWayPointIndex = 0; }
        }

        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPointIndex].transform.position, Time.deltaTime * speed);
    }
}
