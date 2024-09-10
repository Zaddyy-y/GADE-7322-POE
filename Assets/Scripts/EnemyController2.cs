using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class EnemyController2 : MonoBehaviour
{
    //same as the first enemy controller script, except with the 2nd enemy prefab and a different destination
    private NavMeshAgent Enemy2;
    
    
    
    void Start()
    {
        Enemy2 = GetComponent<NavMeshAgent>();
        GameObject enemy2Target = GameObject.Find("Enemy2Target");
        Enemy2.SetDestination(enemy2Target.transform.position);
    }

   

    
}
