using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinballActivate : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        GameObject go = GameObject.Find("pinball");
        if (go)
        {
            go.SetActive(false);
        }
    }
}
