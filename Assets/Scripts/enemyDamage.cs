using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour
{
    private int damage = 5;
    private float range = 2f;
    private float currentRange;
    private float attackCD = 10f;
    private float currentCD;
    public playerStats stats;
    public int killDamage;
    public Transform player;

    private void Start()
    {
        killDamage = stats.currentHealth;
        currentCD = 0;
        

    }

    void Update()
    {
        var distance = Vector3.Distance(player.position, transform.position);


        if (currentCD < Time.time && distance < range && killDamage < 20 ) //time.time is the real world time since start. 
        {
            killDamage += damage;
            currentCD =attackCD + Time.time; //sets it to real world time + 10
            
        }
        
        



    }
}
