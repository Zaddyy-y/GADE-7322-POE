using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    public GameObject tower1;
    public GameObject tower2;
    public GameObject tower3;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) 
        {
            tower1.SetActive(false);
            tower2.SetActive(true);
            Debug.Log("O PRESSED");
        }

        else if (Input.GetKeyDown(KeyCode.P))
        {
            tower2.SetActive(false);
            tower3.SetActive(true);
        }
    }




   
}
