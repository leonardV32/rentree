using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class main_script : MonoBehaviour
{               // VARIABLES UNITY //
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    private Rigidbody2D rgdb2;
    private SpriteRenderer spriteRenderer;
    private float direction;
    private Animator animator;
    
    private Mouvement controls;
    private void OnEnable()
    {
        controls = new Mouvement();
        controls.Enable();
                    // PERFORMED //


        controls.Mvmt.directionnelle.performed += MoveOnPerformed;

        // CANCELED //

        controls.Mvmt.directionnelle.canceled += MoveOnCanceled;

        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        var horizontalSpeed = Mathf.Abs(rgdb2.velocity.x);
        if (horizontalSpeed < maxSpeed)
        {
            rgdb2.AddForce(new Vector2(speed * direction, 0));
        }

        var verticalSpeed = Mathf.Abs(rgdb2.velocity.y);
        if (verticalSpeed < maxSpeed)
        {
            rgdb2.AddForce(new Vector2(0, speed * direction));
        }
    }
}
