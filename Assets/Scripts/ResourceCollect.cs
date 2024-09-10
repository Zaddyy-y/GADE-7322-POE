using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceCollection : MonoBehaviour
{
    [SerializeField]
    public int resourceCount = 3;

    void OnMouseDown()
    {
        resourceCount++;
        Debug.Log("NEW RESOURCE");
        gameObject.SetActive(false);
    }
}
