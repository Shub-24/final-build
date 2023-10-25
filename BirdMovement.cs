
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public Transform[] waypoints;
    private Transform currentWaypoint;
    private int currentIndex;

    void Start()
    {
        currentIndex = UnityEngine.Random.Range(0, waypoints.Length); 
        currentWaypoint = waypoints[currentIndex];
        transform.position = currentWaypoint.position;
        
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, currentWaypoint.position) < 0.1f)
        {
            currentIndex = UnityEngine.Random.Range(0, waypoints.Length); 
            currentWaypoint = waypoints[currentIndex];
            
        }

        float step = 7f * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, currentWaypoint.position, step);
    }
}