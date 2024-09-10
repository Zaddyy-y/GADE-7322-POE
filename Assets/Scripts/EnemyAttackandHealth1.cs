using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackandHealth : MonoBehaviour
{
    public GameObject Enemy;
    public float targetRange = 2f;
    public int enemyHealth = 80;
    public static int enemyAttackDamage = 10;

    

    void Update()
    {
        Distance();
    }

    void Distance()
    {
        float distance = Vector3.Distance(transform.position, Enemy.transform.position);

        if (distance <= targetRange)
        {
            //AttackedConditions();
            
        }
    }

    /*void AttackedConditions()
    {
        enemyHealth -= DefenderAttackandHealth.defenderAttackDamage;
        enemyHealth -= TowerAttackandHealth.towerAttackDamage;
        if (enemyHealth <= 0)
        {
           gameObject.SetActive(false);
        }
    }
    */

    
}
