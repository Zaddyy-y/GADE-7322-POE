using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackAndHealth : MonoBehaviour
{
    public float health = 50;
    public float defenderHealth = 100;
    public Image enemyHealthBar;
    public Image defenderHealthBar;



    private void Update()
    {
        if (health <= 0)
        {
            Destroy(EnemySpawn.Instance1);
            
        }

        if (defenderHealth <= 0)
        {
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            LowerEnemyHealth(5);
        }



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            LowerDefenderHealth(5);
        }
    }

    public void LowerEnemyHealth(float damage)
    {
        health -= damage;
        enemyHealthBar.fillAmount = health / 50;

        
    }

    public void LowerDefenderHealth(float damage)
    {
        defenderHealth -= damage;
        defenderHealthBar.fillAmount = health / 100;
    }


}
