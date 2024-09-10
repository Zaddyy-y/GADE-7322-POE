using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class EnemyController : MonoBehaviour
{
    private NavMeshAgent Enemy1; //navmesh agent
    
    
    
    void Start()
    {
        
        Enemy1 = GetComponent<NavMeshAgent>();
        GameObject enemy1Target = GameObject.Find("Enemy1Target"); //Finds the "Enemy1Target" game object
        Enemy1.SetDestination(enemy1Target.transform.position); //sets the destination of the navmesh agent to the position of the enemyTarget1 variable
    }

   

    
}
