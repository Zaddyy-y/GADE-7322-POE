using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//SIMILAR SCRIPT TO ATTACKANDHEALTH SCRIPT, JUST FOR ENEMY3 AND DEFENDER3 SPECIFICALLY
public class AttackAndHealth3 : MonoBehaviour
{
    public float health = 80;
    public Image healthBar;
    public float defenderHealth = 80;
    public Image defenderHealthBar;



    private void Update()
    {
        if (health <= 0)
        {
            Destroy(EnemySpawn.Instance3);

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
            LowerHealth(8);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.CompareTag("Enemy"))
        {
            LowerDefenderHealth(20);
        }

    }

    

    public void LowerHealth(float damage)
    {
        health -= damage;
        healthBar.fillAmount = health / 80;


    }

    public void LowerDefenderHealth(float damage)
    {
        defenderHealth -= damage;
        defenderHealthBar.fillAmount = health / 80;
    }
}
