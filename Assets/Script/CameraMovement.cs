using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]

public class CameraMovement : MonoBehaviour
{
    [SerializeField] InputActionAsset playerControls;
    InputAction movement;

    CharacterController character;
    Vector3 moveVector;
    [SerializeField] float speed = 2f;

    private void Start()
    {
        var gameplayActionMap = playerControls.FindActionMap("Camera");

        movement = gameplayActionMap.FindAction("Camera");

        movement.performed += OnMovementChanged;
        movement.canceled += OnMovementChanged;
        movement.Enable();

        character = GetComponent<CharacterController>();
    }

    private void Update()
    {
        character.transform.Rotate(moveVector, speed);
    }

    private void OnMovementChanged(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();
        moveVector= new Vector3(0, direction.x, 0);

    }
}
