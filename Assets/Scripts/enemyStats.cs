using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStats : MonoBehaviour
{
    private int initialHealth = 20;
    public int scalingHealth;
    public int currentHealth;
    public int totalDamage;
    [SerializeField] private gameManager gameManager;
    

    public void Start()
    {
        
    }

    public void dealdamage(int gunDamage)
    {
        
        totalDamage -= gunDamage;
        
    }

    public void Update()
    {
        currentHealth = initialHealth + scalingHealth + totalDamage;
        
        
        

        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
            gameManager.gameEnded = true;
            Debug.Log(gameManager.gameEnded);
            

            
        }
        
    }






    public void OnGUI()
    {
        GUI.color = Color.red;
        GUI.skin.label.fontSize = 20;

        GUI.Label(new Rect(100, 100, 1000, 50), currentHealth.ToString());
    }

    
}
