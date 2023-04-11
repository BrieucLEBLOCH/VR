using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactables : MonoBehaviour
{
    public UnityEvent OnGrab; // événement déclenché lors de la saisie de l'objet
    public UnityEvent OnRelease; // événement déclenché lors du relâchement de l'objet

    private Rigidbody rb; // référence au composant Rigidbody attaché à l'objet
    public bool isGrabbed = false; // indique si l'objet est actuellement saisi

    [SerializeField] float forceMult;
    Vector3 lastPos;
    Vector3 force;
    private float timer;

    private void Start()
    {
        // Récupère la référence au composant Rigidbody attaché à l'objet
        rb = GetComponent<Rigidbody>();
        lastPos = transform.position;
    }

    private void FixedUpdate()
    {
        force = transform.position - lastPos;
        lastPos = transform.position;
    }

    // Fonction appelée lorsqu'un contrôleur VR saisit l'objet
    public void Grab()
    {
        isGrabbed = true;

        // Désactive la physique de l'objet pour éviter les problèmes de collision lors du déplacement
        rb.isKinematic = true;
    }

    // Fonction appelée lorsqu'un contrôleur VR relâche l'objet
    public void Release()
    {
        isGrabbed = false;

        // Réactive la physique de l'objet pour qu'il puisse interagir à nouveau avec les autres objets de la scène
        rb.isKinematic = false;
        rb.AddForce(force * forceMult);
    }

    // Fonction appelée pour déplacer l'objet vers une position donnée (la position du contrôleur VR)
    public void MoveTo(Vector3 position)
    {
        transform.position = position;
    }
}