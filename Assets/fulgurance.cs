// GENERATED AUTOMATICALLY FROM 'Assets/fulgurance.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Fulgurance : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Fulgurance()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""fulgurance"",
    ""maps"": [
        {
            ""name"": ""Attack"",
            ""id"": ""90b3b63a-05b7-4297-a869-d6960eab3c05"",
            ""actions"": [
                {
                    ""name"": ""Sword"",
                    ""type"": ""Button"",
                    ""id"": ""76e4527b-fb2f-4174-8042-25a69b86d21f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8edb353b-77a8-4f28-bc17-094ca2db6643"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sword"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Attack
        m_Attack = asset.FindActionMap("Attack", throwIfNotFound: true);
        m_Attack_Sword = m_Attack.FindAction("Sword", throwIfNotFound: true);
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

    // Attack
    private readonly InputActionMap m_Attack;
    private IAttackActions m_AttackActionsCallbackInterface;
    private readonly InputAction m_Attack_Sword;
    public struct AttackActions
    {
        private @Fulgurance m_Wrapper;
        public AttackActions(@Fulgurance wrapper) { m_Wrapper = wrapper; }
        public InputAction @Sword => m_Wrapper.m_Attack_Sword;
        public InputActionMap Get() { return m_Wrapper.m_Attack; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AttackActions set) { return set.Get(); }
        public void SetCallbacks(IAttackActions instance)
        {
            if (m_Wrapper.m_AttackActionsCallbackInterface != null)
            {
                @Sword.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnSword;
                @Sword.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnSword;
                @Sword.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnSword;
            }
            m_Wrapper.m_AttackActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Sword.started += instance.OnSword;
                @Sword.performed += instance.OnSword;
                @Sword.canceled += instance.OnSword;
            }
        }
    }
    public AttackActions @Attack => new AttackActions(this);
    public interface IAttackActions
    {
        void OnSword(InputAction.CallbackContext context);
    }
}
