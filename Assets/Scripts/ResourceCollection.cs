using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceCollect : MonoBehaviour
{
    public TextMeshProUGUI ResourceCounter;
    [SerializeField]
    public static int resourceCount = 3; //starting the game with 3 resources

    private void Update()
    {
        ResourceCounter.text = "AVAILABLE RESOURCES = " + resourceCount;
    }
    void OnMouseDown()
    {
        // when the player clicks a resource, it adds to the number of available resources and deactivates that resource so it can spawn again
        resourceCount++;
        Debug.Log("NEW RESOURCE");
        gameObject.SetActive(false);
    }
}
