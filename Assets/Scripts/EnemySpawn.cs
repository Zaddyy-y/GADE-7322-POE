
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class EnemySpawn : MonoBehaviour
{
    
   
    public static GameObject Instance1;
    private static GameObject Instance2;
    private static GameObject Instance3;
    
    public GameObject EnemyPrefab1; //enemy prefabs
    public GameObject EnemyPrefab2;
    public GameObject EnemyPrefab3;
    public GameObject EnemySpawnPoint1; //spawn point prefabs
    public GameObject EnemySpawnPoint2;
    public GameObject EnemySpawnPoint3;

    private void Start()
    {
        StartCoroutine(EnemySpawner()); // running the coroutine on Start
    }

   



    IEnumerator EnemySpawner() //spawns enemies
    {
        for (int i = 0; i < 3; i++) 
        {

            yield return new WaitForSeconds(2f); //interval between the spawning of enemies

            Vector3 spawnPos1 = EnemySpawnPoint1.transform.position; //setting the spawn point for enemy 1
            Instance1 = Instantiate(EnemyPrefab1, spawnPos1, Quaternion.identity); //spawning enemy 1 at the specified spawn point

            yield return new WaitForSeconds(10f);

            Vector3 spawnPos2 = EnemySpawnPoint2.transform.position; //setting the spawn point for enemy 2
            Instance2 = Instantiate(EnemyPrefab2, spawnPos2, Quaternion.identity); //spawning enemy 2 at the specified spawn point

            yield return new WaitForSeconds(10f);

            Vector3 spawnPos3 = EnemySpawnPoint3.transform.position; //setting the spawn point for enemy 3
            Instance3 = Instantiate(EnemyPrefab3, spawnPos3, Quaternion.identity); //spawning enemy 2 at the specified spawn point

        }

    }

   




}
