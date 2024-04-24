using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    GameObject go;
    GameObject go2;
    void Awake()
    {
        go = GameObject.Find("Trampoline");
        go2 = GameObject.Find("Balle");

        go.SetActive(false);
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        go.SetActive(true);
        go2.SetActive(false);
    }
}
