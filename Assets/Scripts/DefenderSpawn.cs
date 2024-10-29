using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawn : MonoBehaviour
{
    public GameObject SpawnPrefab;
    //public GameObject DefenderPrefab;
    public float offsetX = -2f;
    public float offsetZ = -2f; //offset values
    public float offsetY = -1f;

   

    void OnMouseDown()
    {
        if (ResourceCollect.resourceCount > 0) // if the resources collected are more than 0, then a defender can be spawned
        {
            Vector3 spawnPos = SpawnPrefab.transform.position;
            spawnPos.x += offsetX;
            spawnPos.z += offsetZ; // offsets the spawn position so defedners spawn in the correct place
            spawnPos.y += offsetY;
            //GameObject Defender = Instantiate(DefenderPrefab, spawnPos, Quaternion.identity); //instantiates the defender prefab at the specified position
            ResourceCollect.resourceCount --; // Once a defender is spawned, the resource amount is decreased by 1
            Debug.Log("LOST ONE");
            Debug.Log("Count" +  ResourceCollect.resourceCount);
        }
    }

}
