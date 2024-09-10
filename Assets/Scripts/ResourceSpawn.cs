using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResourceSpawn : MonoBehaviour
{
    public GameObject[] ResourceSpawnPoints;
    public GameObject ResourcePrefab;



    void Start()
    {
        StartCoroutine(ResourceSpawner());
    }

    IEnumerator ResourceSpawner()
    {
        List<GameObject> RandomizedSpawnPoints = ResourceSpawnPoints.ToList();

        while (RandomizedSpawnPoints.Count > 0)
        {
            
            int i = Random.Range(0, RandomizedSpawnPoints.Count);
            GameObject spawnPosition = RandomizedSpawnPoints[i];

            yield return new WaitForSeconds(5f);

            Instantiate(ResourcePrefab, spawnPosition.transform.position, Quaternion.identity);

            


        }
    }

    void OnMouseDown()
    {
        
    }
}
