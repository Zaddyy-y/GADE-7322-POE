using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class EnemyController2 : MonoBehaviour
{
    private NavMeshAgent Enemy2;
    
    
    
    void Start()
    {
        Enemy2 = GetComponent<NavMeshAgent>();
        GameObject enemy2Target = GameObject.Find("Enemy2Target");
        Enemy2.SetDestination(enemy2Target.transform.position);
    }

   

    
}
