using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender3Upgrade : MonoBehaviour
{
    public GameObject defender1;
    public GameObject defenderupgrade1;
    public GameObject defenderupgrade2;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (defender1.activeInHierarchy == true)
            {
                defender1.SetActive(false);
                defenderupgrade1.SetActive(true);
            }

            else if (defender1.activeInHierarchy == false && defenderupgrade1.activeInHierarchy == true)
            {
                defenderupgrade1.SetActive(false);
                defenderupgrade2.SetActive(true);
            }
        }
    }
}
