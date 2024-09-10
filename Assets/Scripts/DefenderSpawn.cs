using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawn : MonoBehaviour
{
    public GameObject SpawnPrefab;
    public GameObject DefenderPrefab;
    public float offsetX = -2f;
    public float offsetZ = -2f;
    public float offsetY = -1f;
    

    void OnMouseDown()
    {
        if (ResourceCollect.resourceCount > 0)
        {
            Vector3 spawnPos = SpawnPrefab.transform.position;
            spawnPos.x += offsetX;
            spawnPos.z += offsetZ;
            spawnPos.y += offsetY;
            GameObject Defender = Instantiate(DefenderPrefab, spawnPos, Quaternion.identity);
            ResourceCollect.resourceCount --;
            Debug.Log("LOST ONE");
            Debug.Log("Count" +  ResourceCollect.resourceCount);
        }
    }
}
