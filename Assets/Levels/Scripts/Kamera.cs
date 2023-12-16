using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public Transform target;
    public float smoothness = 0.1f;
    public float zoomOutAmount = 2f; // Adjust this value to control the zoom-out effect

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
        {
            // Smoothly interpolate the camera position towards the target
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothness);

            // Zoom out the camera
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, zoomOutAmount, smoothness);
        }
    }
}


