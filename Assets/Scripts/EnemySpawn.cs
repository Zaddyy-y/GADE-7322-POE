using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;
    public GameObject enemySpawnPoint1;
    public GameObject enemySpawnPoint2;
    public GameObject enemySpawnPoint3;

    private void Start()
    {
        StartCoroutine(EnemySpawner());
    }

    IEnumerator EnemySpawner()
    {
        for (int i = 0; i < 3; i++)
        {

            yield return new WaitForSeconds(2f);

            Vector3 spawnPos1 = enemySpawnPoint1.transform.position;
            GameObject enemy1 = Instantiate(enemyPrefab1, spawnPos1, Quaternion.identity);

            yield return new WaitForSeconds(3f);

            Vector3 spawnPos2 = enemySpawnPoint2.transform.position;
            GameObject enemy2 = Instantiate(enemyPrefab2, spawnPos2, Quaternion.identity);

            yield return new WaitForSeconds(3f);

            Vector3 spawnPos3 = enemySpawnPoint3.transform.position;
            GameObject enemy3 = Instantiate(enemyPrefab3, spawnPos3, Quaternion.identity);
            
        }

    }
}
