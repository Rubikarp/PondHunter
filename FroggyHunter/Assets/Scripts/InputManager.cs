// GENERATED AUTOMATICALLY FROM 'Assets/Importers & Settings/Input/FrogController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FrogController"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""08387c62-9c5b-4277-9bf1-33d567acf65f"",
            ""actions"": [
                {
                    ""name"": ""MoveFrog"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c5e6bb67-1863-4aa3-bb49-42452cf13ebc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveViewfinder"",
                    ""type"": ""Value"",
                    ""id"": ""25fda2ba-81fa-403c-ab81-9f85a6f183e7"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TongueShoot"",
                    ""type"": ""Button"",
                    ""id"": ""2b3fb7d7-47a5-4c25-aaf3-90746e1e578f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PullInsect"",
                    ""type"": ""Button"",
                    ""id"": ""8c01623e-1aec-4243-82b1-7a67ba3e8fe8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""97d1b784-a2c9-43eb-8297-420ef320cc12"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveFrog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ZQSD [Keyboard]"",
                    ""id"": ""24d5f7e1-44b8-4961-9039-c08b0b97750f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveFrog"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9a05205d-9c70-469c-be38-ac2e09ec40b8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveFrog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c4ad1269-fa5a-44eb-8670-95bcf8b8dfb0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveFrog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c3cfaaf2-496f-4d06-8735-b38be9b32ed7"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveFrog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""26a76f0f-ca68-4b61-9b68-aa9cfa0cfe75"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveFrog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a509397a-94b7-4191-9e97-80aff33be220"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TongueShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""782c0368-306f-46aa-b505-96ed2b658699"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TongueShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29e5cf39-0bf1-495c-880d-29e6ee06219f"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveViewfinder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""DirectionalArrows [Keyboard]"",
                    ""id"": ""d3583571-5919-48b7-af55-daf45399ba42"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveViewfinder"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5cd0710a-31ad-42e5-80b1-23c2d0892faf"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveViewfinder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""70c59e39-01fc-4691-88ce-f9577ee926a9"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveViewfinder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""989413c4-693b-4f34-aefc-6437740a38c7"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveViewfinder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""759d17f7-bbb0-4336-80fd-32ff0f1dbf3c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveViewfinder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9ab5ec86-214b-4386-b85b-356976c1baf8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PullInsect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17db1ad7-67f8-4d9e-902b-a8b3e76c98dc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PullInsect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MoveFrog = m_Player.FindAction("MoveFrog", throwIfNotFound: true);
        m_Player_MoveViewfinder = m_Player.FindAction("MoveViewfinder", throwIfNotFound: true);
        m_Player_TongueShoot = m_Player.FindAction("TongueShoot", throwIfNotFound: true);
        m_Player_PullInsect = m_Player.FindAction("PullInsect", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MoveFrog;
    private readonly InputAction m_Player_MoveViewfinder;
    private readonly InputAction m_Player_TongueShoot;
    private readonly InputAction m_Player_PullInsect;
    public struct PlayerActions
    {
        private @InputManager m_Wrapper;
        public PlayerActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveFrog => m_Wrapper.m_Player_MoveFrog;
        public InputAction @MoveViewfinder => m_Wrapper.m_Player_MoveViewfinder;
        public InputAction @TongueShoot => m_Wrapper.m_Player_TongueShoot;
        public InputAction @PullInsect => m_Wrapper.m_Player_PullInsect;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MoveFrog.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveFrog;
                @MoveFrog.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveFrog;
                @MoveFrog.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveFrog;
                @MoveViewfinder.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveViewfinder;
                @MoveViewfinder.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveViewfinder;
                @MoveViewfinder.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveViewfinder;
                @TongueShoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTongueShoot;
                @TongueShoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTongueShoot;
                @TongueShoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTongueShoot;
                @PullInsect.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPullInsect;
                @PullInsect.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPullInsect;
                @PullInsect.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPullInsect;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveFrog.started += instance.OnMoveFrog;
                @MoveFrog.performed += instance.OnMoveFrog;
                @MoveFrog.canceled += instance.OnMoveFrog;
                @MoveViewfinder.started += instance.OnMoveViewfinder;
                @MoveViewfinder.performed += instance.OnMoveViewfinder;
                @MoveViewfinder.canceled += instance.OnMoveViewfinder;
                @TongueShoot.started += instance.OnTongueShoot;
                @TongueShoot.performed += instance.OnTongueShoot;
                @TongueShoot.canceled += instance.OnTongueShoot;
                @PullInsect.started += instance.OnPullInsect;
                @PullInsect.performed += instance.OnPullInsect;
                @PullInsect.canceled += instance.OnPullInsect;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMoveFrog(InputAction.CallbackContext context);
        void OnMoveViewfinder(InputAction.CallbackContext context);
        void OnTongueShoot(InputAction.CallbackContext context);
        void OnPullInsect(InputAction.CallbackContext context);
    }
}
