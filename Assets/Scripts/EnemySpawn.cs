using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject EnemyPrefab1;
    public GameObject EnemyPrefab2;
    public GameObject EnemyPrefab3;
    public GameObject EnemySpawnPoint1;
    public GameObject EnemySpawnPoint2;
    public GameObject EnemySpawnPoint3;

    private void Start()
    {
        StartCoroutine(EnemySpawner());
    }

    IEnumerator EnemySpawner()
    {
        for (int i = 0; i < 3; i++)
        {

            yield return new WaitForSeconds(2f);

            Vector3 spawnPos1 = EnemySpawnPoint1.transform.position;
            GameObject Enemy1 = Instantiate(EnemyPrefab1, spawnPos1, Quaternion.identity);

            yield return new WaitForSeconds(3f);

            Vector3 spawnPos2 = EnemySpawnPoint2.transform.position;
            GameObject Enemy2 = Instantiate(EnemyPrefab2, spawnPos2, Quaternion.identity);

            yield return new WaitForSeconds(3f);

            Vector3 spawnPos3 = EnemySpawnPoint3.transform.position;
            GameObject Enemy3 = Instantiate(EnemyPrefab3, spawnPos3, Quaternion.identity);
            
        }

    }
}
