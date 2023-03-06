using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerOld : MonoBehaviour
{
    /* public bool activeTP;
    public Transform posFP; //Third Person
    public Transform posTP; //First Person
    public Transform follow; //Camera follow the player
    public Vector3 offset;
    //properties of Camera Third Person
    public float rotSpeed;//control rotatios speed of camera
    public float rotMin, rotMax;//limit for rotate the camera 
    float mouseX, mouseY;//variables for get and set the value from the cursor of the mouse
    public Transform target, player;


    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        follow = posFP;
        
    }
    void Update() 
    {    
        transform.position = follow.position + offset;       
    }
    public void Cam()
    {
        mouseX += rotSpeed * Input.GetAxis("Mouse X");
        mouseX -= rotSpeed * Input.GetAxis("Mouse Y");//is minor for no inverter the camera
        mouseY = Mathf.Clamp(mouseY, rotMin, rotMax);

        target.rotation = Quaternion.Euler(mouseY,mouseX, 0.0f);
        player.rotation = Quaternion.Euler(0.0f,mouseX, 0.0f);
    }
    private void LateUpdate() 
    {
        Cam();
        if(activeTP == false && Input.GetKeyDown(KeyCode.Tab))
        {      
            activeTP = true;
            transform.position = posFP.position; 
            Debug.Log("Camera Third person");
        }
        else if(activeTP == true && Input.GetKeyDown(KeyCode.Tab))
        {
            activeTP = false;
            transform.position = posTP.position;
            transform.LookAt(player);
            Debug.Log("Camera First person");
        }    
    } */
}
