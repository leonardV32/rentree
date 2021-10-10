using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Bar_Ennemy : MonoBehaviour
{
    public int damage;
    [SerializeField] private int maxHealthEnnemy;
    private int currentHealthEnnemy;
    public GameObject scriptHolder;
    private Enemy_Spawn enemy_Spawn;

    //public Enemy_Spawn enemy_Spawn;
    

    // Start is called before the first frame update
    void Start()
    {
        scriptHolder = GameObject.FindWithTag("Holder");
        enemy_Spawn = scriptHolder.GetComponent<Enemy_Spawn>();
        currentHealthEnnemy = maxHealthEnnemy;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {   
        if (col.gameObject.tag == "Sword" /*&& col.gameObject.tag != "Target"*/)
            DamageTaken();
    }

    void DamageTaken()
    {
        if (currentHealthEnnemy > 0)
        {
            currentHealthEnnemy -= damage;
            Debug.Log(currentHealthEnnemy);
        }

        else
        {
            enemy_Spawn.Spawn();
            Destroy(this.gameObject);
            
        }

    }

  
}
