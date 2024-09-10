using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderAttackandHealth : MonoBehaviour
{
    public GameObject Defender;
    public float targetRange = 2f; //Range for when the defender will take damage and deal damage
    public int defenderHealth = 100;
    public static int defenderAttackDamage = 10;

    

    void Update()
    {
        Distance();
    }

    void Distance()
    {
        float distance = Vector3.Distance(transform.position, Defender.transform.position);

        if (distance <= targetRange)
        {
            AttackedConditions();
            
        }
    }

    void AttackedConditions()
    {
        defenderHealth -= EnemyAttackandHealth.enemyAttackDamage;
        if (defenderHealth <= 0)
        {
           gameObject.SetActive(false);
        }
    }

    
}
