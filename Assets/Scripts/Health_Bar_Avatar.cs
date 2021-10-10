using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Bar_Avatar : MonoBehaviour
{

    public int damage;
    [SerializeField] private int maxHealth;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

   
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {   
        if (col.gameObject.tag == "Enemy")
            DamageTaken();
    }
    void DamageTaken()
    {
        if (currentHealth > 0)
        {
            currentHealth -= damage;
        }

        else
        {
            Destroy(this.gameObject);
        }

    }
}
