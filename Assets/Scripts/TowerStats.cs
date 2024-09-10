using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerStats : MonoBehaviour
{
    public int maxhealthAmount;
    public int attackAmount;

    public void ReduceHealth(int damage)
    {
        maxhealthAmount -= damage;
    }

    public void DamageGiven(GameObject target)
    {
        var attributes = target.GetComponent<TowerStats>();
        if (attributes != null)
        {
            attributes.ReduceHealth(attackAmount);
        }
    }
}
