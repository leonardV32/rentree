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

    private GameObject attack_colliderup;
    private GameObject attack_colliderdown;
    private GameObject attack_colliderright;
    private GameObject attack_colliderleft;

    private bool can_move = false;
    private bool Slice;
    
    private Mouvement controls;
    

    private void OnEnable()
    {
        controls = new Mouvement();
        
        
        controls.Enable();

                    // PERFORMED //
        controls.Mvmt.directionelle.performed += MoveOnPerformed;
        controls.Attack.Fulgurance.performed += AttackOnPerformed;


                    // CANCELED //
        controls.Mvmt.directionelle.canceled += MoveOnCanceled;
        controls.Attack.Fulgurance.canceled += AttackOnCanceled;

    }

    private void MoveOnPerformed(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<Vector2>();
        animator.SetBool("moving_ok", true); // d�clenche la transition de idle � walk dans l'animator  
        animator.SetFloat("horizontal", direction.x);   
        animator.SetFloat("vertical", direction.y);

    }


    private void AttackOnPerformed(InputAction.CallbackContext obj)
    {
        animator.SetBool("attack_ok", true);

        if (animator.GetFloat("vertical") > 0)
        {
            attack_colliderup.SetActive(true);  //up
        }

        else if (animator.GetFloat("vertical") < 0)
        {
            attack_colliderdown.SetActive(true);    //down
        }
       
        else if (animator.GetFloat("horizontal") > 0)
        {
            attack_colliderright.SetActive(true);   //right
           
        }
           
        else //(animator.GetFloat("horizontal") < 0)
        {
            attack_colliderleft.SetActive(true);    //left
        }
            

    }

    private void MoveOnCanceled(InputAction.CallbackContext obj)
    {
        direction = Vector2.zero;
    }

    private void AttackOnCanceled(InputAction.CallbackContext obj)
    {
        animator.SetBool("attack_ok", false);
        attack_colliderup.SetActive(false);  
        attack_colliderdown.SetActive(false);
        attack_colliderright.SetActive(false);
        attack_colliderleft.SetActive(false);
    }



    // Start is called before the first frame update
    void Start()
    {
        rgdb2 = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        can_move = true;

        attack_colliderup = this.gameObject.transform.GetChild(0).gameObject;
        attack_colliderdown = this.gameObject.transform.GetChild(1).gameObject;
        attack_colliderright = this.gameObject.transform.GetChild(2).gameObject;
        attack_colliderleft = this.gameObject.transform.GetChild(3).gameObject;

        attack_colliderup.SetActive(false);  
        attack_colliderdown.SetActive(false);
        attack_colliderright.SetActive(false);
        attack_colliderleft.SetActive(false);
    }
    void EnableController()
    {
        if (can_move)
            OnEnable();
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalSpeed = Mathf.Abs(rgdb2.velocity.x);
        var verticalSpeed = Mathf.Abs(rgdb2.velocity.y);
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
