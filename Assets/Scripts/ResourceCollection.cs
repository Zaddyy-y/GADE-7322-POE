using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceCollect : MonoBehaviour
{
    [SerializeField]
    public static int resourceCount = 3;

    void OnMouseDown()
    {
        resourceCount++;
        Debug.Log("NEW RESOURCE");
        gameObject.SetActive(false);
    }
}
