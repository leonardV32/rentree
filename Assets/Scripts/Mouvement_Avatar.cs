using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mouvement_Avatar : MonoBehaviour
{                     // VARIABLES UNITY //
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    private Rigidbody2D rgdb2;
    private SpriteRenderer spriteRenderer;
    private Vector2 direction;
    private Animator animator;
    
    private Mouvement controls;
    private void OnEnable()
    {
        controls = new Mouvement();
        controls.Enable();

                    // PERFORMED //
        controls.Mvmt.directionelle.performed += MoveOnPerformed;

                    // CANCELED //
        controls.Mvmt.directionelle.canceled += MoveOnCanceled;
   
    }

    private void MoveOnPerformed(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<Vector2>();
    }

    private void MoveOnCanceled(InputAction.CallbackContext obj)
    {
        direction = Vector2.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
        rgdb2 = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        var horizontalSpeed = Mathf.Abs(rgdb2.velocity.x);
        var verticalSpeed = Mathf.Abs(rgdb2.velocity.y);
        // (horizontaspeed, verticalspeed
    }


    private void FixedUpdate()
    {
        var horizontalSpeed = Mathf.Abs(rgdb2.velocity.x);
        if (horizontalSpeed < maxSpeed)
        {
            rgdb2.AddForce(speed * direction);
        }

        var verticalSpeed = Mathf.Abs(rgdb2.velocity.y);
        if (verticalSpeed < maxSpeed)
        {
            rgdb2.AddForce(speed * direction);
        }

        
    }

}
