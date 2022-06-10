using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDamage : MonoBehaviour
{
    private int gunDamage = 5;
    private float gunFR;
    private float gunCD;
    public int damageTaken;
    public float destructionTime = 5f;

    public void Start()
    {
        
        Destroy(this.gameObject, destructionTime);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemy") 
        {
            other.gameObject.GetComponent<enemyStats>().dealdamage(gunDamage);


            Destroy(this.gameObject); 

        }

        if (other.transform.tag == "Ground")
        {
            Destroy(this.gameObject);

        }
    }

    public void Update()
    {
        
    }
    
}
