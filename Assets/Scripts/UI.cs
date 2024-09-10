using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI resourceCheck;

    void Update()
    {
        resourceCheck.text = "AVAILABLE RESOURCES = " + ResourceCollect.resourceCount;
    }
}
