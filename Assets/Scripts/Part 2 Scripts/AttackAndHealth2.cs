using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackAndHealth2 : MonoBehaviour
{
    public float health = 100;
    public Image healthBar;
    public float defenderHealth = 50;
    public Image defenderHealthBar;



    private void Update()
    {
        if (health <= 0)
        {
            Destroy(EnemySpawn.Instance2);

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
            LowerHealth(10);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            LowerDefenderHealth(30);
        }
    }

    public void LowerHealth(float damage)
    {
        health -= damage;
        healthBar.fillAmount = health / 100;


    }

    public void LowerDefenderHealth(float damage)
    {
        defenderHealth -= damage;
        defenderHealthBar.fillAmount = health / 50;
    }
}
