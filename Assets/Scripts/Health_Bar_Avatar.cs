using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Bar_Avatar : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    
    void Start()
    {
        currentHealth = maxHealth;
    }

   
    void Update()
    {
        
    }

    /*void DamageTaken(int damage)
    {
        currentHealth -= damage;
    }
    */
}
