using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Bar_Ennemy : MonoBehaviour
{
    public int damage;
    [SerializeField] private int maxHealthEnnemy;
    private int currentHealthEnnemy;
    

    // Start is called before the first frame update
    void Start()
    {
        currentHealthEnnemy = maxHealthEnnemy;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        DamageTaken();
    }

    void DamageTaken()
    {
        if (currentHealthEnnemy > 0)
        {
            currentHealthEnnemy -= damage;
        }

        else
            Destroy(this.gameObject);
    }

  
}
