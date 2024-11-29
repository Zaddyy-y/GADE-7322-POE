using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProximityTrigger : MonoBehaviour
{
    public MeshRenderer towerRenderer; // Reference to the MeshRenderer of the tower
    public int windowMaterialIndex = 3; // Index of the window material in the material array (adjust if needed)

    private int enemiesInRange = 0; // Keeps track of the number of enemies nearby
    public float maxProximityValue = 3.0f; // The maximum intensity of the effect
    public float intensityMultiplier = 0.5f; // How much the effect intensifies with each enemy

    void Start()
    {
        // Ensure this object has a trigger collider
        Collider collider = GetComponent<Collider>();
        if (collider == null || !collider.isTrigger)
        {
            Debug.LogError("This object needs a trigger collider set as isTrigger = true.");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            enemiesInRange++;
            float proximityValue = Mathf.Clamp01(enemiesInRange * intensityMultiplier);
            UpdateMaterialProximity(proximityValue); // Update material intensity based on number of enemies
            Debug.Log($"Enemy entered range. Enemies in range: {enemiesInRange}");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            enemiesInRange = Mathf.Max(0, enemiesInRange - 1);

            // Reduce the intensity when enemies leave the range
            float proximityValue = Mathf.Clamp01(enemiesInRange * intensityMultiplier);
            UpdateMaterialProximity(proximityValue);

            Debug.Log($"Enemy exited range. Enemies in range: {enemiesInRange}");
        }
    }

    void UpdateMaterialProximity(float proximityValue)
    {
        // Get the material array from the renderer
        Material[] materials = towerRenderer.materials;

        // Ensure the material array has the expected index
        if (windowMaterialIndex < 0 || windowMaterialIndex >= materials.Length)
        {
            Debug.LogError($"Invalid material index {windowMaterialIndex}. Renderer has {materials.Length} materials.");
            return;
        }

        // Access the specific material for the windows
        Material windowMaterial = materials[windowMaterialIndex];

        // Update the proximity value in the shader
        windowMaterial.SetFloat("_EnemyProximity", proximityValue);

        // Reassign the modified materials array back to the renderer
        towerRenderer.materials = materials;

        Debug.Log($"_EnemyProximity set to: {proximityValue}");
    }
}
