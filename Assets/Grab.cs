using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARSubsystems;

public class Grab : MonoBehaviour
{
    Controls controls;
    [SerializeField] float grabDistanceRight = 0.2f; // distance maximale de saisie de l'objet
    [SerializeField] float grabRayDistanceLeft = 5f; // distance maximale de saisie de l'objet avec RayCast
    public LayerMask GrabbableLayer; // masque de couche pour les objets interactifs

    private Interactables currentInteractable = null; // l'objet actuellement saisi
    private Vector3 grabOffset = Vector3.zero; // l'offset de position entre la position de l'objet et la position du contrôleur VR lors de la saisie

    private void Awake()
    {
        controls = new Controls();

        controls.Grab.GrabRight.performed += GripPressedRight;
        controls.Grab.GrabRight.canceled += GripReleased;
        
        controls.Grab.GrabLeft.performed += GripPressedLeft;
        controls.Grab.GrabLeft.canceled += GripReleased;
    }

    private void Update()
    {
        Vector3 vectorNull = new Vector3(0,0,0);
        // Déplace l'objet saisi vers la position du contrôleur VR lors de la saisie
        if (currentInteractable != null)
        {
            currentInteractable.MoveTo(transform.position + grabOffset);
        }
    }

    private void GripPressedRight(InputAction.CallbackContext context)
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, grabDistanceRight, GrabbableLayer);
        foreach (Collider collider in hitColliders)
        {
            // Récupère le composant "Interactable" de l'objet touché par le raycast
            Interactables interactable = collider.GetComponent<Interactables>();

            // Si l'objet est interactif et n'est pas déjà saisi, le saisit
            if (interactable != null && !interactable.isGrabbed)
            {
                currentInteractable = interactable;
                grabOffset = currentInteractable.transform.position - transform.position;
                currentInteractable.Grab();
            }
        }

    }

    private void GripPressedLeft(InputAction.CallbackContext context)
    {
        //Effectue un raycast depuis la position du contrôleur VR dans la direction de son avant - bras
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, grabRayDistanceLeft, GrabbableLayer))
        {
            // Récupère le composant "Interactable" de l'objet touché par le raycast
            Interactables interactable = hit.collider.GetComponent<Interactables>();

            // Si l'objet est interactif et n'est pas déjà saisi, le saisit
            if (interactable != null && !interactable.isGrabbed)
            {
                currentInteractable = interactable;
                grabOffset = currentInteractable.transform.position - transform.position;
                currentInteractable.Grab();
            }
        }
    }

    private void GripReleased(InputAction.CallbackContext context)
    {
        // Si un objet est actuellement saisi, le relâche
        if (currentInteractable != null)
        {
            currentInteractable.Release();
            currentInteractable = null;
        }
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}