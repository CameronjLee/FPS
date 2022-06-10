using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController Controller;
    [SerializeField] private float speed = 12f;

    Vector3  velocity;
    public float gravity = -9.81f;
    public float jumpHeight = 3f; //desired jump

    public Transform groundCheck;
    public float groundDistance = 0.3f; 
    public LayerMask groundMask; //checks object colission
    bool isGrounded;

    public Transform initialPos;
    public Transform finalPos;


    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z; //provides directional movement based on camera angle

        Controller.Move(move * speed * Time.deltaTime);



        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //creates sphere using position, distance and collision as variables#

        if (isGrounded)
        {
            velocity.y = 0f;
        }


        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity); //math equation for calculating desired jump force requirement
        }

        
        velocity.y += gravity * (Time.deltaTime); //y velocity is equal to gravity*time
        
        Controller.Move(velocity * Time.deltaTime); //velocity times time twice because thats how the equation works in physics


    }


   
}
