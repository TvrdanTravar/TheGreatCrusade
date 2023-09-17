using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public float Speed = 5;
    public float zoomSpeed = 15f;

    void Update()
    {
        float xAxisValue = Input.GetAxis("Horizontal") * Speed;
        float zAxisValue = Input.GetAxis("Vertical") * Speed;
        float yValue = 0.0f;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            yValue = -Speed * zoomSpeed;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            yValue = Speed * zoomSpeed;
        }

        transform.position = new Vector3(transform.position.x + xAxisValue, transform.position.y + yValue, transform.position.z + zAxisValue);
    }
}
