using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Validate3 : MonoBehaviour
{
    private GameObject[] gameObjects;
    void Awake()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Validate3");
        foreach (GameObject go in gameObjects)
        {
            if (go)
            {
                go.SetActive(false);
            }
        }
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        foreach (GameObject go in gameObjects)
        {
            if (go)
            {
                go.SetActive(true);
            }
        }
    }
}
