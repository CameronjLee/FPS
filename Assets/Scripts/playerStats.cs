using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour
{
    private int initialHealth = 20;
    public int currentHealth;
    [SerializeField] private enemyDamage enemy;
    public bool areDead = false;

    
    void start()
    {
        
    }

    private void Update()
    {
        currentHealth = initialHealth - enemy.killDamage;

        if (currentHealth >= 0)
        {
            areDead = true;
        }

        
    }

    
    public void OnGUI()
    {
        GUI.color = Color.red;
        GUI.skin.label.fontSize = 20;
        
        GUI.Label(new Rect(10,10,500,50), currentHealth.ToString());
    }
}
