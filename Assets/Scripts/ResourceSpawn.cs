using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResourceSpawn : MonoBehaviour
{
    public GameObject[] ResourceSpawnPoints; //an array for the different places resources can spawn
    public GameObject ResourcePrefab; //resource prefab



    void Start()
    {
        StartCoroutine(ResourceSpawner()); //starts coroutine on start
    }

    IEnumerator ResourceSpawner()
    {
        List<GameObject> RandomizedSpawnPoints = ResourceSpawnPoints.ToList(); //adds the spawnpoints in the array to a list

        while (RandomizedSpawnPoints.Count > 0)
        {
            
            int i = Random.Range(0, RandomizedSpawnPoints.Count); //randomizes the spawn points
            GameObject spawnPosition = RandomizedSpawnPoints[i]; //stores the selected random spawnpoint in the variable

            yield return new WaitForSeconds(10f); //interval between spawning of a resource

            Instantiate(ResourcePrefab, spawnPosition.transform.position, Quaternion.identity); //spawns a resource at the random spawn point




        }
    }

    void OnMouseDown()
    {
        
    }
}
