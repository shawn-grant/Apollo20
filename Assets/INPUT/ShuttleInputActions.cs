// GENERATED AUTOMATICALLY FROM 'Assets/INPUT/ShuttleInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ShuttleInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ShuttleInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ShuttleInputActions"",
    ""maps"": [
        {
            ""name"": ""Flight"",
            ""id"": ""fa34b287-533b-418f-818e-17829995e37d"",
            ""actions"": [
                {
                    ""name"": ""Pitch"",
                    ""type"": ""Value"",
                    ""id"": ""b11506e1-8819-4512-93d2-eef2bffcf6d9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Value"",
                    ""id"": ""ed880146-b1e4-45e6-85ce-f3c2aa7d1665"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Yaw"",
                    ""type"": ""Value"",
                    ""id"": ""554025c6-09bb-4214-a86c-9d9439243e30"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""c18f31dd-1e53-497b-9c32-75e024f260c1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ee18f793-e77e-4b13-9ec4-4bb84e8c7cbf"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""992a19c8-5b6f-48b8-ab49-1611b2e9d1c3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""b05f3416-292c-4db2-b04c-5fb6ab5b28db"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0a69ace3-a6b0-4946-a629-cf0b04b22dab"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9f9f384f-3d66-461b-97ae-19d41fad43ef"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller"",
                    ""id"": ""73b6d7ff-a656-4e33-8568-f23ba8051a04"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""55b4c616-e206-437b-a2fa-ebdb322cfc3c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2cb103ae-32d4-4026-b2b3-f45158de828b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""cad515e5-6942-4ea6-9793-804ea849f022"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e4534502-0ce9-494b-86ff-c867fc4e6bfb"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""546adb31-3dbc-4d39-ae56-fe2f12e2844d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""f9744b11-a29f-4db5-89ee-7e11e81436be"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""731df6e5-6cda-4f5d-845e-c4d3e54c4c11"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""df51af73-b4f2-4cb6-b5d2-3991f9ece589"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller"",
                    ""id"": ""79b82ee6-796f-43e2-ab12-0972d97e778e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2a9d0cdb-ea30-45f9-9323-05ca7849a418"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""60e737c9-2699-42ed-94fe-7d7e5eeb4ddd"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""9bfde487-acfb-4ba4-8bbf-6f9417dd0c93"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a43eaade-bc71-4811-87fd-e5d08ff607a1"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4c534fac-104d-4e48-b0bc-e786c9b9b500"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller"",
                    ""id"": ""38bb8db5-08ec-4cbe-b0cf-1a7d3e923d3c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1716bc96-d22f-47cd-81b8-b4014b53ba67"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c52a34b4-b504-4aa2-88a8-37b102e3486e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Defense"",
            ""id"": ""7665f628-dac9-4c1b-a270-eb3c1da3e5a9"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""6cd34d6a-7766-40ae-8961-9199890e661b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aabb7ff0-10a7-48fe-89cc-068d95d1e33e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Flight
        m_Flight = asset.FindActionMap("Flight", throwIfNotFound: true);
        m_Flight_Pitch = m_Flight.FindAction("Pitch", throwIfNotFound: true);
        m_Flight_Roll = m_Flight.FindAction("Roll", throwIfNotFound: true);
        m_Flight_Yaw = m_Flight.FindAction("Yaw", throwIfNotFound: true);
        // Defense
        m_Defense = asset.FindActionMap("Defense", throwIfNotFound: true);
        m_Defense_Newaction = m_Defense.FindAction("New action", throwIfNotFound: true);
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

    // Flight
    private readonly InputActionMap m_Flight;
    private IFlightActions m_FlightActionsCallbackInterface;
    private readonly InputAction m_Flight_Pitch;
    private readonly InputAction m_Flight_Roll;
    private readonly InputAction m_Flight_Yaw;
    public struct FlightActions
    {
        private @ShuttleInputActions m_Wrapper;
        public FlightActions(@ShuttleInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pitch => m_Wrapper.m_Flight_Pitch;
        public InputAction @Roll => m_Wrapper.m_Flight_Roll;
        public InputAction @Yaw => m_Wrapper.m_Flight_Yaw;
        public InputActionMap Get() { return m_Wrapper.m_Flight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FlightActions set) { return set.Get(); }
        public void SetCallbacks(IFlightActions instance)
        {
            if (m_Wrapper.m_FlightActionsCallbackInterface != null)
            {
                @Pitch.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnPitch;
                @Pitch.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnPitch;
                @Pitch.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnPitch;
                @Roll.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnRoll;
                @Yaw.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnYaw;
                @Yaw.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnYaw;
                @Yaw.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnYaw;
            }
            m_Wrapper.m_FlightActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pitch.started += instance.OnPitch;
                @Pitch.performed += instance.OnPitch;
                @Pitch.canceled += instance.OnPitch;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Yaw.started += instance.OnYaw;
                @Yaw.performed += instance.OnYaw;
                @Yaw.canceled += instance.OnYaw;
            }
        }
    }
    public FlightActions @Flight => new FlightActions(this);

    // Defense
    private readonly InputActionMap m_Defense;
    private IDefenseActions m_DefenseActionsCallbackInterface;
    private readonly InputAction m_Defense_Newaction;
    public struct DefenseActions
    {
        private @ShuttleInputActions m_Wrapper;
        public DefenseActions(@ShuttleInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Defense_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Defense; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefenseActions set) { return set.Get(); }
        public void SetCallbacks(IDefenseActions instance)
        {
            if (m_Wrapper.m_DefenseActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_DefenseActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_DefenseActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_DefenseActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_DefenseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public DefenseActions @Defense => new DefenseActions(this);
    public interface IFlightActions
    {
        void OnPitch(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
    }
    public interface IDefenseActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
