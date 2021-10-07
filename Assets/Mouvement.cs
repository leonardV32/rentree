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
        },
        {
            ""name"": ""Attack"",
            ""id"": ""8bab9722-1b78-4331-9697-a375fce213b7"",
            ""actions"": [
                {
                    ""name"": ""Fulgurance"",
                    ""type"": ""Value"",
                    ""id"": ""427f1a44-9cbe-40f8-a053-422bd2187c9e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""66542d82-44ad-4738-ad9e-140a734637a7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fulgurance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mvmt
        m_Mvmt = asset.FindActionMap("Mvmt", throwIfNotFound: true);
        m_Mvmt_directionelle = m_Mvmt.FindAction("directionelle", throwIfNotFound: true);
        // Attack
        m_Attack = asset.FindActionMap("Attack", throwIfNotFound: true);
        m_Attack_Fulgurance = m_Attack.FindAction("Fulgurance", throwIfNotFound: true);
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

    // Attack
    private readonly InputActionMap m_Attack;
    private IAttackActions m_AttackActionsCallbackInterface;
    private readonly InputAction m_Attack_Fulgurance;
    public struct AttackActions
    {
        private @Mouvement m_Wrapper;
        public AttackActions(@Mouvement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fulgurance => m_Wrapper.m_Attack_Fulgurance;
        public InputActionMap Get() { return m_Wrapper.m_Attack; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AttackActions set) { return set.Get(); }
        public void SetCallbacks(IAttackActions instance)
        {
            if (m_Wrapper.m_AttackActionsCallbackInterface != null)
            {
                @Fulgurance.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnFulgurance;
                @Fulgurance.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnFulgurance;
                @Fulgurance.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnFulgurance;
            }
            m_Wrapper.m_AttackActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fulgurance.started += instance.OnFulgurance;
                @Fulgurance.performed += instance.OnFulgurance;
                @Fulgurance.canceled += instance.OnFulgurance;
            }
        }
    }
    public AttackActions @Attack => new AttackActions(this);
    public interface IMvmtActions
    {
        void OnDirectionelle(InputAction.CallbackContext context);
    }
    public interface IAttackActions
    {
        void OnFulgurance(InputAction.CallbackContext context);
    }
}
