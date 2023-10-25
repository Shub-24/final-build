
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BirdMovement : MonoBehaviour
{
    public Transform[] waypoints;
    private Transform currentWaypoint;
    private int currentIndex;
    private SpriteRenderer spriteRenderer; // Added SpriteRenderer

    void Start()
    {
        currentIndex = Random.Range(0, waypoints.Length);
        currentWaypoint = waypoints[currentIndex];
        transform.position = currentWaypoint.position;
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component
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

        // Flip the sprite based on movement direction
        if (transform.position.x < currentWaypoint.position.x)
        {
            spriteRenderer.flipX = false; // Face right
        }
        else if (transform.position.x > currentWaypoint.position.x)
        {
            spriteRenderer.flipX = true; // Face left
        }
    }
}