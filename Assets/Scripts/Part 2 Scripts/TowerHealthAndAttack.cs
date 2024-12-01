using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerHealthAndAttack : MonoBehaviour
{
    public float health = 200; // Health of the tower
    public Image healthBar; // Tower health bar UI component
    public float enemyHealth = 80; // Enemy health
    public Image enemyHealthBar; // Enemy health bar component

    // Add these for the bloom effect
    public Material bloomMaterial; // Material with the Shader Graph
    public float maxBloomIntensity = 10f; // Maximum bloom intensity
    public float bloomThreshold = 0.3f; // Health threshold for bloom activation


    private void Update()
    {
        // Destroy the tower if its health reaches 0 or less
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        // Destroy the enemy if its health reaches 0 or less
        if (enemyHealth <= 0)
        {
            Destroy(EnemySpawn.Instance3);
        }

        // Update the bloom effect based on the current tower health
        UpdateBloomEffect();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the enemy is close enough to do damage
        if (other.CompareTag("Enemy"))
        {
            LowerTowerHealth(50);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        // Check to do damage to the enemy
        if (other.CompareTag("Enemy"))
        {
            LowerEnemyHealth(8);
        }
    }

    public void LowerTowerHealth(float damage)
    {
        // Reduces health by damage and displays it on the health bar
        health -= damage;
        healthBar.fillAmount = health / 200;
    }

    public void LowerEnemyHealth(float damage)
    {
        // Same as above but for the enemy
        enemyHealth -= damage;
        enemyHealthBar.fillAmount = enemyHealth / 80;
    }

    private void UpdateBloomEffect()
    {
        if (bloomMaterial == null)
        {
            Debug.LogError("Bloom material not assigned!");
            return;
        }

        // Calculate health percentage (0 to 1)
        float healthPercent = Mathf.Clamp01(health / 200f);

        // Check if bloom should activate
        float intensity = (healthPercent < bloomThreshold)
            ? Mathf.Lerp(0f, maxBloomIntensity, 1 - healthPercent / bloomThreshold)
            : 0f;

        // Update shader properties
        bloomMaterial.SetFloat("_Health", healthPercent);
        bloomMaterial.SetFloat("_Intensity", intensity);

        Debug.Log($"Health: {healthPercent}, Intensity: {intensity}");
    }
}
