using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerHealthAndAttack : MonoBehaviour
{
    public float health = 200;
    public Image healthBar;
    public float enemyHealth = 80;
    public Image enemyHealthBar;



    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);

        }
        if (enemyHealth <= 0)
        {
            Destroy(EnemySpawn.Instance3);

        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            LowerTowerHealth(50);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            LowerEnemyHealth(8);
        }

    }


    public void LowerTowerHealth(float damage)
    {
        health -= damage;
        healthBar.fillAmount = health / 200;

    }

    public void LowerEnemyHealth(float damage)
    {
        enemyHealth -= damage;
        enemyHealthBar.fillAmount = health / 80;

    }



}
