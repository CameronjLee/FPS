using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public bool gameEnded = false;
    public int roundNo = 1;
    public enemyStats enemyStats;
    public Transform enemyInitial;
    public Transform enemyFinal;
    [SerializeField] private GameObject enemy;
    public enemyDamage player;

    public void Update()
    {
        if (gameEnded == true)
        {
            roundNo++;
            enemyStats.scalingHealth = 5 * roundNo;
            //Instantiate(enemy, enemyInitial.position, enemyInitial.rotation);

            GameObject go = Instantiate(enemy);
            enemyDamage enemy = go.GetComponent<enemyDamage>().player;
            enemyDamage.player = player;
            

        }
    }

    

    public void OnGUI()
    {
        GUI.color = Color.black;
        GUI.skin.label.fontSize = 20;

        GUI.Label(new Rect(50, 50, 50, 50), roundNo.ToString());
    }
}
