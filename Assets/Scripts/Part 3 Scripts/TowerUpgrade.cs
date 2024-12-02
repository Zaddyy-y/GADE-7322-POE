using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    // The logic remains the same for upgrading the defenders, with the health being increased specifically for each different tower and defender
    public GameObject tower1;
    public GameObject tower2;
    public GameObject tower3;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) //If the O key is pressed the base tower will be inactive and the first upgraded tower will be made active. If the O key is pressed again, the 2nd tower
        {
            if (tower1.activeInHierarchy == true)
            {
                tower1.SetActive(false);
                tower2.SetActive(true);
            }

            else if (tower1.activeInHierarchy == false && tower2.activeInHierarchy == true) //If the O key is pressed again, the first upgraded tower will be disabled, and the 2nd upgraded tower will be enabled
            {
                tower2.SetActive(false);
                tower3.SetActive(true);
            }
        }

        
    }




   
}
