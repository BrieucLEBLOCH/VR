using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactables : MonoBehaviour
{
    public UnityEvent OnGrab; // �v�nement d�clench� lors de la saisie de l'objet
    public UnityEvent OnRelease; // �v�nement d�clench� lors du rel�chement de l'objet

    private Rigidbody rb; // r�f�rence au composant Rigidbody attach� � l'objet
    public bool isGrabbed = false; // indique si l'objet est actuellement saisi

    [SerializeField] float forceMult;
    //Vector3 lastPos;
    //Vector3 force;

    private void Start()
    {
        // R�cup�re la r�f�rence au composant Rigidbody attach� � l'objet
        rb = GetComponent<Rigidbody>();
        //rb.velocity= new Vector3(1,1,1);
        //lastPos = transform.position;
    }

    private void Update()
    {
        //force = transform.position - lastPos;
        //lastPos = transform.position;
    }

    // Fonction appel�e lorsqu'un contr�leur VR saisit l'objet
    public void Grab()
    {
        isGrabbed = true;

        // D�sactive la physique de l'objet pour �viter les probl�mes de collision lors du d�placement
        //rb.velocity = Vector3.zero;
        rb.isKinematic = true;
    }

    // Fonction appel�e lorsqu'un contr�leur VR rel�che l'objet
    public void Release(Vector3 force)
    {
        isGrabbed = false;

        // R�active la physique de l'objet pour qu'il puisse interagir � nouveau avec les autres objets de la sc�ne
        rb.isKinematic = false;
        //rb.velocity = new Vector3(1, 1, 1);
        rb.AddForce(force * forceMult, ForceMode.VelocityChange);
    }

    // Fonction appel�e pour d�placer l'objet vers une position donn�e (la position du contr�leur VR)
    public void MoveTo(Vector3 position)
    {
        transform.position = position;
    }
}