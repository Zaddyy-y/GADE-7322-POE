using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceCollection : MonoBehaviour
{
    [SerializeField]
    public int resourceCount = 3; //starting the game with 3 resources

    void OnMouseDown()
    {
        // when the player clicks a resource, it adds to the number of available resources and deactivates that resource so it can spawn again
        resourceCount++;
        Debug.Log("NEW RESOURCE");
        gameObject.SetActive(false);
    }
}
