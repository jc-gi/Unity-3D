using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float mouseSensivity = 80f;
    public Transform player;
    float xRotation = 0.0f;
    

    private void Update() 
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;
        
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);
        
        transform.localRotation = Quaternion.Euler(xRotation, 0.0f, 0.0f);
        player.Rotate(Vector3.up*mouseX);
    }

}
