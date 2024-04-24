using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    private GameObject[] gameObjects;

    private void Start()
    {
    }

    private void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
