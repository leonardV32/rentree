using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Sword_Attack : MonoBehaviour
{

    private Fulgurance controls;
    public int damage = 10;
    public Rigidbody2D rgbd2Sword;

    /*
    private void OnEnable()
    {
        controls = new Fulgurance();
        controls.Enable();

        controls.Attack.Sword.performed += SliceOnPerformed;
    }

    /*private void SliceOnPerformed(Input.CallbackContext obj)
    {
        
    } 
    */
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
