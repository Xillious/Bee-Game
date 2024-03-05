using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    private Vector3 offset;

    private bool isDragging = false;
    private Vector2 lastMousePosition;

    private Vector3 inputDir;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += inputDir * 5f * Time.deltaTime;

        if (Input.GetMouseButtonDown(1))
        {
            //1 is right mouse button
            isDragging = true;
            lastMousePosition = Input.mouseScrollDelta;
        }

        if (Input.GetMouseButtonUp(1))
        {
            isDragging = false;
        }

        if (isDragging == true)
        {
            Vector2 mouseMovementDelta = (Vector2)Input.mousePosition - lastMousePosition;

            inputDir.x = mouseMovementDelta.x;
            inputDir.y = mouseMovementDelta.y;

            Debug.Log(mouseMovementDelta);
            lastMousePosition = Input.mousePosition;
        }

    }
}
