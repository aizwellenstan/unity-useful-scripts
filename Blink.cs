using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehavior
{

    public float distance = 5.0f;

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            BlinkForward();
        }
    }

    public void BlinkForward()
    {
        RaycastHit hit;
        Vector3 destination = transform.position + transform.forward * distance;

        if(Physics.Linecast(transform.position, destination, out hit))
        {
            destination = transform.postion + transform.forward * (hit.distance - 1f);
        }

        if(Physics.Raycast(destination, -Vector3.up, out hit))
        {
            destination = hit.point;
            destionation.y = 0.5f;
            transform.position = destination;
        }
    }
}