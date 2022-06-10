using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{

    public float mouseSense = 100f;

    public Transform playerBody;

    float xRotation = 0f;
    

    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //locks camera to centre
    }

    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSense * Time.deltaTime; //assigns value between -1 and 1
        float mouseY = Input.GetAxis("Mouse Y") * mouseSense * Time.deltaTime;



        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        
        playerBody.Rotate(Vector3.up * mouseX);

    }
}
