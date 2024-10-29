using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackAndHealth : MonoBehaviour
{
    public float health = 100;
    public Image healthBar;



    private void Update()
    {
        if (health <= 0)
        {
            Destroy(EnemySpawn.Instance1);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            LowerHealth(20);
        }

    }

    public void LowerHealth(float damage)
    {
        health -= damage;
        healthBar.fillAmount = health / 100;
    }


}
