using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoots : MonoBehaviour
{
    
    public GameObject projectile;
    public float launchVelocity = 700f;
    private GameObject bullet;

    void Start()
    {
        
    }

    


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            bullet = Instantiate(projectile, transform.position, transform.rotation);

            bullet.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0,0,launchVelocity));

            
           
        }
        

        
    }
}
