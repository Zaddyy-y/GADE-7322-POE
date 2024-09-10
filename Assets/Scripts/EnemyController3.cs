using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class EnemyController3 : MonoBehaviour
{
    //same as the first enemy controller script, except with the 3rd enemy prefab and a different destination
    private NavMeshAgent Enemy3;
    
    
    
    void Start()
    {
        Enemy3 = GetComponent<NavMeshAgent>();
        GameObject enemy3Target = GameObject.Find("Enemy3Target");
        Enemy3.SetDestination(enemy3Target.transform.position);
    }

   

    
}
