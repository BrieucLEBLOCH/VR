using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOffGravity : MonoBehaviour
{
    private GameObject[] gameObjects;

    private void Start()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("MovingObjects");
    }
    void OnTriggerEnter(Collider other)
    {
        foreach (GameObject go in gameObjects)
        {
            Rigidbody rb = go.GetComponent<Rigidbody>();
            if (rb != null)
            {
                    rb.isKinematic = false;
            }
        }
        this.gameObject.SetActive(false);
    }
}
