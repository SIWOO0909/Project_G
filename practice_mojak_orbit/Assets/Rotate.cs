using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 10f;
    private bool isRotating = false;
    private float startMousPosition;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isRotating = true;
            startMousPosition = Input.mousePosition.x;
        }
        else if (Input.GetMouseButtonDown(0))
        {
            isRotating = false;
        }

        if (isRotating)
        {
            float currentMousePosition = Input.mousePosition.x;
            float mouseMovement = currentMousePosition - startMousPosition;

            transform.Rotate(Vector3.up, -mouseMovement*speed*Time.deltaTime);
            startMousPosition = currentMousePosition;
        }
    }
}
