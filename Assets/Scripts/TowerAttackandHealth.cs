using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttackandHealth : MonoBehaviour
{
    public GameObject Tower;
    public float targetRange = 2f;
    public int towerHealth = 120;
    public static int towerAttackDamage = 20;

    

    void Update()
    {
        Distance();
    }

    void Distance()
    {
        float distance = Vector3.Distance(transform.position, Tower.transform.position);

        if (distance <= targetRange)
        {
            //AttackedConditions();
            
        }
    }

    /*void AttackedConditions()
    {
        towerHealth -= EnemyAttackandHealth.enemyAttackDamage;
        if (towerHealth <= 0)
        {

           gameObject.SetActive(false);
        }
    }
    */
    
}
