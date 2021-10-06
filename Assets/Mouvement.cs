// GENERATED AUTOMATICALLY FROM 'Assets/Mouvement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Mouvement : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Mouvement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Mouvement"",
    ""maps"": [
        {
            ""name"": ""Mvmt"",
            ""id"": ""e1a9e21a-8d97-4424-8f73-d7f48220fd76"",
            ""actions"": [
                {
                    ""name"": ""directionelle"",
                    ""type"": ""Value"",
                    ""id"": ""1941aac9-c41f-43df-b321-9b7617e4c42d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""12401eb3-ab9b-4c6c-abad-d25dcbdac09a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""directionelle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5210c18f-59b5-4f3f-8742-13e53432d5fb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""directionelle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""931f8d09-d924-4aa7-ad53-824d4e8d1661"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""directionelle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5fd89624-55c8-4a86-a7ca-f015c8698346"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""directionelle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""144c99ee-7a7e-41d6-934c-ef1f64c50479"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""directionelle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mvmt
        m_Mvmt = asset.FindActionMap("Mvmt", throwIfNotFound: true);
        m_Mvmt_directionelle = m_Mvmt.FindAction("directionelle", throwIfNotFound: true);
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

    // Mvmt
    private readonly InputActionMap m_Mvmt;
    private IMvmtActions m_MvmtActionsCallbackInterface;
    private readonly InputAction m_Mvmt_directionelle;
    public struct MvmtActions
    {
        private @Mouvement m_Wrapper;
        public MvmtActions(@Mouvement wrapper) { m_Wrapper = wrapper; }
        public InputAction @directionelle => m_Wrapper.m_Mvmt_directionelle;
        public InputActionMap Get() { return m_Wrapper.m_Mvmt; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MvmtActions set) { return set.Get(); }
        public void SetCallbacks(IMvmtActions instance)
        {
            if (m_Wrapper.m_MvmtActionsCallbackInterface != null)
            {
                @directionelle.started -= m_Wrapper.m_MvmtActionsCallbackInterface.OnDirectionelle;
                @directionelle.performed -= m_Wrapper.m_MvmtActionsCallbackInterface.OnDirectionelle;
                @directionelle.canceled -= m_Wrapper.m_MvmtActionsCallbackInterface.OnDirectionelle;
            }
            m_Wrapper.m_MvmtActionsCallbackInterface = instance;
            if (instance != null)
            {
                @directionelle.started += instance.OnDirectionelle;
                @directionelle.performed += instance.OnDirectionelle;
                @directionelle.canceled += instance.OnDirectionelle;
            }
        }
    }
    public MvmtActions @Mvmt => new MvmtActions(this);
    public interface IMvmtActions
    {
        void OnDirectionelle(InputAction.CallbackContext context);
    }
}
