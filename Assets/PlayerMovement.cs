using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    Controls movement;

    CharacterController character;
    Vector3 moveVector;
    [SerializeField] float speed = 10f;
    [SerializeField] Camera mainCamera;

    // Start is called before the first frame update
    private void Awake()
    {
        movement = new Controls();
        movement.Move.Move.performed += OnMovementChanged;
        movement.Move.Move.canceled += OnMovementChanged;

        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 camDirFor = mainCamera.transform.forward;
        camDirFor.y = 0;
        Vector3 camDirRight = mainCamera.transform.right;
        camDirRight.y = 0;
        character.transform.position += camDirFor * moveVector.y * speed;
        character.transform.position += camDirRight * moveVector.x * speed;

    }

    private void OnMovementChanged(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();
        moveVector = new Vector3(direction.x, direction.y, 0);
    }

    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }
}
