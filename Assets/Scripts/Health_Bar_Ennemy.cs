using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Bar_Ennemy : MonoBehaviour
{

    public int maxHealthEnnemy = 100;
    public int currentHealthEnnemy;


    // Start is called before the first frame update
    void Start()
    {
        currentHealthEnnemy = maxHealthEnnemy;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DamageTaken(int damage)
    {
        currentHealthEnnemy -= damage;
    }

    /*void DamageTaken(int damage)
    {
        if (currentHealthEnnemy > 0)
        {
            currentHealthEnnemy -= bullet_Damage
        }
        
        else
            Destroy(this.gameObject)


    }

    */


}
