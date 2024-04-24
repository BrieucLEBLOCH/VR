using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI.Table;

public class Grab : MonoBehaviour
{
    Controls controls;
    [SerializeField] float grabDistanceRight = 0.2f;
    [SerializeField] float grabRayDistanceLeft = 5f;
    public LayerMask GrabbableLayer;

    private Interactables currentInteractable = null;
    private Vector3 grabOffset = Vector3.zero;

    Vector3 OriginRotation;
    Vector3 force;
    Queue<Vector3> posQueue;
    Quaternion rot;

    private void Awake()
    {
        controls = new Controls();
        posQueue = new Queue<Vector3>();

        controls.Grab.GrabRight.performed += GripPressedRight;
        controls.Grab.GrabRight.canceled += GripReleased;
        
        controls.Grab.GrabLeft.performed += GripPressedLeft;
        controls.Grab.GrabLeft.canceled += GripReleased;

        rot = transform.rotation;
    }

    private void Update()
    {
        Vector3 vectorNull = new Vector3(0,0,0);
        if (currentInteractable != null)
        {
            currentInteractable.MoveTo(transform.position);
            if (currentInteractable.tag != "Rampe") 
            {
                currentInteractable.transform.rotation= transform.rotation;            
            }
            if (currentInteractable.tag == "Rampe") 
            {
                currentInteractable.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
            }

        }

        if (posQueue.Count < 10)
        {
            posQueue.Enqueue(transform.position);
        }
        else
        {
            posQueue.Dequeue();
            posQueue.Enqueue(transform.position);
        }

        force = posQueue.Peek() - transform.position;

    }

    private void GripPressedRight(InputAction.CallbackContext context)
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, grabDistanceRight, GrabbableLayer);
        foreach (Collider collider in hitColliders)
        {
            Interactables interactable = collider.GetComponent<Interactables>();

            if (interactable != null && !interactable.isGrabbed)
            {
                currentInteractable = interactable;
                currentInteractable.Grab();
            }
        }

    }

    private void GripPressedLeft(InputAction.CallbackContext context)
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, grabRayDistanceLeft, GrabbableLayer))
        {
            Interactables interactable = hit.collider.GetComponent<Interactables>();

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
        if (currentInteractable != null)
        {
            currentInteractable.Release(-(force / Time.deltaTime));
            force = Vector3.zero;
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