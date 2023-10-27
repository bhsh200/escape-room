using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Move: MonoBehaviour
{
    public Vector3 newPosition; // The new position to move the object to
    public float moveSpeed = 5.0f; // Speed of the movement

    private bool isMoving = false;

    void Update()
    {
        // Check for mouse click (left mouse button)
        if (Input.GetMouseButtonDown(0))
        {
            // Calculate a ray from the camera to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits this object
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                // Start moving the object to the new position
                isMoving = true;
            }
        }

        // If we're moving, interpolate the object's position towards the new position
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, newPosition, moveSpeed * Time.deltaTime);

            // Check if we've reached the new position
            if (transform.position == newPosition)
            {
                isMoving = false;
            }
        }
    }
}

