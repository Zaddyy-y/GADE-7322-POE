using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class EnemyController : MonoBehaviour
{
    private NavMeshAgent Enemy1;
    
    
    
    void Start()
    {
        Enemy1 = GetComponent<NavMeshAgent>();
        GameObject enemy1Target = GameObject.Find("Enemy1Target");
        Enemy1.SetDestination(enemy1Target.transform.position);
    }

   

    
}
