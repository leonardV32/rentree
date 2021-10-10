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

    void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.tag == "Enemy" /*&& col.gameObject.tag !="Sword"*/)
            DamageTaken();
    }
    void DamageTaken()
    {
        if (currentHealth > 0)
        {
            currentHealth -= damage;
            Debug.Log(currentHealth);
        }

        else
        {
            Destroy(this.gameObject);
        }

    }
}
