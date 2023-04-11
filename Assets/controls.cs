// GENERATED AUTOMATICALLY FROM 'Assets/controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""controls"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""e67ee9eb-75c5-44f9-8307-89bd1730814f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""246f573f-34bf-4e3b-b661-f7141ad3cf4f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ZQSD"",
                    ""id"": ""06aa6cab-bb7e-482b-af8b-cc41345bb681"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6c6d45fa-ad2d-4e62-ab8b-945e0ae051fd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""25e24e89-aab0-4a04-aaa0-619886026169"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6f07ce1e-fd4a-40df-8732-5d84982b2475"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f940b580-5a1e-454e-95ff-10261eb38a3b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ce825cbc-ec3f-4c8d-b696-7598e358e848"",
                    ""path"": ""<XRController>{LeftHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""51013666-6bb2-4f37-9c4d-1d431f36ae8c"",
            ""actions"": [
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""ce3841e9-06af-48aa-b672-8a71b066ffa2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bcf9c7b1-c30e-441e-a7c9-24856b7d4141"",
                    ""path"": ""<XRController>{RightHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Grab"",
            ""id"": ""71af51ec-1434-4f87-b544-fdf3c4f1b6f1"",
            ""actions"": [
                {
                    ""name"": ""GrabRight"",
                    ""type"": ""Button"",
                    ""id"": ""bb3857ea-5a96-4e33-a6e1-471545ffd049"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GrabLeft"",
                    ""type"": ""Button"",
                    ""id"": ""521edcb9-72ab-4ebc-bedd-c1cc4a335c80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""070224c1-d6d1-4dee-84bb-79e95b976e71"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GrabRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5666faa3-6ddb-40b0-ba50-8961b4b258e2"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GrabLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_Move = m_Move.FindAction("Move", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Camera = m_Camera.FindAction("Camera", throwIfNotFound: true);
        // Grab
        m_Grab = asset.FindActionMap("Grab", throwIfNotFound: true);
        m_Grab_GrabRight = m_Grab.FindAction("GrabRight", throwIfNotFound: true);
        m_Grab_GrabLeft = m_Grab.FindAction("GrabLeft", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_Move;
    public struct MoveActions
    {
        private @Controls m_Wrapper;
        public MoveActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Move_Move;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Camera;
    public struct CameraActions
    {
        private @Controls m_Wrapper;
        public CameraActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Camera => m_Wrapper.m_Camera_Camera;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Camera.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnCamera;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // Grab
    private readonly InputActionMap m_Grab;
    private IGrabActions m_GrabActionsCallbackInterface;
    private readonly InputAction m_Grab_GrabRight;
    private readonly InputAction m_Grab_GrabLeft;
    public struct GrabActions
    {
        private @Controls m_Wrapper;
        public GrabActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @GrabRight => m_Wrapper.m_Grab_GrabRight;
        public InputAction @GrabLeft => m_Wrapper.m_Grab_GrabLeft;
        public InputActionMap Get() { return m_Wrapper.m_Grab; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GrabActions set) { return set.Get(); }
        public void SetCallbacks(IGrabActions instance)
        {
            if (m_Wrapper.m_GrabActionsCallbackInterface != null)
            {
                @GrabRight.started -= m_Wrapper.m_GrabActionsCallbackInterface.OnGrabRight;
                @GrabRight.performed -= m_Wrapper.m_GrabActionsCallbackInterface.OnGrabRight;
                @GrabRight.canceled -= m_Wrapper.m_GrabActionsCallbackInterface.OnGrabRight;
                @GrabLeft.started -= m_Wrapper.m_GrabActionsCallbackInterface.OnGrabLeft;
                @GrabLeft.performed -= m_Wrapper.m_GrabActionsCallbackInterface.OnGrabLeft;
                @GrabLeft.canceled -= m_Wrapper.m_GrabActionsCallbackInterface.OnGrabLeft;
            }
            m_Wrapper.m_GrabActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GrabRight.started += instance.OnGrabRight;
                @GrabRight.performed += instance.OnGrabRight;
                @GrabRight.canceled += instance.OnGrabRight;
                @GrabLeft.started += instance.OnGrabLeft;
                @GrabLeft.performed += instance.OnGrabLeft;
                @GrabLeft.canceled += instance.OnGrabLeft;
            }
        }
    }
    public GrabActions @Grab => new GrabActions(this);
    public interface IMoveActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnCamera(InputAction.CallbackContext context);
    }
    public interface IGrabActions
    {
        void OnGrabRight(InputAction.CallbackContext context);
        void OnGrabLeft(InputAction.CallbackContext context);
    }
}
