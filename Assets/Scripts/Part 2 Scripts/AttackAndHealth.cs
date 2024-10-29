using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackAndHealth : MonoBehaviour
{
    public float health = 50; //enemy1 health
    public float defenderHealth = 100; //defender1 health
    public Image enemyHealthBar; //enemy1 UI component
    public Image defenderHealthBar; //defender UI component



    private void Update()
    {
        if (health <= 0) //destroys enemy1 if health reaches 0 or less
        {
            Destroy(EnemySpawn.Instance1);
            
        }

        if (defenderHealth <= 0) //destroys defender1 if health recahes 0 or less
        {
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerStay(Collider other) // defender checks to see if enemy is in range to attack the enemy
    {
        if (other.CompareTag("Enemy"))
        {
            LowerEnemyHealth(10);
        }
    }


    private void OnTriggerEnter(Collider other) // enemy checks to see if defender is in range to attack the defender
    {
        if (other.CompareTag("Enemy"))
        {
            LowerDefenderHealth(5);
        }
        
    }

    public void LowerEnemyHealth(float damage) //removes damage amount from enemy health and updates the health bar
    {
        health -= damage;
        enemyHealthBar.fillAmount = health / 50;

        
    }

    public void LowerDefenderHealth(float damage) //removes damage amount from defenders health and updates their health bar
    {
        defenderHealth -= damage;
        defenderHealthBar.fillAmount = health / 100;
    }


}
