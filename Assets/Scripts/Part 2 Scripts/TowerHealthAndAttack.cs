using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerHealthAndAttack : MonoBehaviour
{
    public float health = 200; //health of tower
    public Image healthBar; //tower health bar UI component
    public float enemyHealth = 80; //enemy health
    public Image enemyHealthBar; //enemy healthbar component



    private void Update()
    {
        if (health <= 0) // destroys the tower if it's health reaches 0 or less 
        {
            Destroy(gameObject);

        }
        if (enemyHealth <= 0) //destroys the enemy if it's health reaches 0 or less
        {
            Destroy(EnemySpawn.Instance3);

        }



    }

    private void OnTriggerEnter(Collider other) //checks if enemy is close enough to do damage
    {
        if (other.CompareTag("Enemy"))
        {
            LowerTowerHealth(50);
        }

    }

    private void OnTriggerStay(Collider other) //checks to do dmage to enemy
    {
        if (other.CompareTag("Enemy"))
        {
            LowerEnemyHealth(8);
        }

    }


    public void LowerTowerHealth(float damage) //reduces health by damage and displays on healthbar
    {
        health -= damage;
        healthBar.fillAmount = health / 200;

    }

    public void LowerEnemyHealth(float damage) //same as above but for enemy
    {
        enemyHealth -= damage;
        enemyHealthBar.fillAmount = health / 80;

    }



}
