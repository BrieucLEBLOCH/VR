using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class RaycastTeleport : MonoBehaviour
{
    [SerializeField] GameObject controller;
    [SerializeField] InputActionAsset playerControls;

    Controls teleportHold;

    bool canTP1;
    bool canTP;

    public LineRenderer trajectoryLineRenderer;

    private Vector3 TargetPos;

    private void Awake()
    {
        teleportHold = new Controls();
    }
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        canTP1 = teleportHold.Teleport.Teleport.IsPressed();
        if (teleportHold.Teleport.Teleport.IsPressed())
        {
            if (canTP == canTP1)
            {
                Ray ray = new Ray(controller.transform.position, -controller.transform.forward);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    TargetPos = hit.point;
                    trajectoryLineRenderer.positionCount = 2;
                    trajectoryLineRenderer.SetPositions(new Vector3[] { controller.transform.position, hit.point });
                }
                else
                {
                    trajectoryLineRenderer.positionCount = 2;
                    trajectoryLineRenderer.SetPositions(new Vector3[] { controller.transform.position, controller.transform.position + -controller.transform.forward * 100 });
                }
            }
        }
        if (teleportHold.Teleport.Teleport.IsPressed() == false)
        {
            if (canTP != canTP1)
            {
                trajectoryLineRenderer.positionCount = 0;
                this.transform.position = TargetPos;
            }
        }
        canTP = teleportHold.Teleport.Teleport.IsPressed();
    }

    private void OnEnable()
    {
        teleportHold.Enable();
    }
    private void OnDisable()
    {
        teleportHold.Disable();
    }
}
