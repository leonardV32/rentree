using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    [SerializeField] public GameObject[] enemies;
    [SerializeField] public GameObject[] spawners;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i < 5; i++)
        {
            Spawn();
        }
        //sprite_enemies = new GameObject[]; pas besoin de cette ligne puique les arrays seront remplis en SerializeField
        //spawn_enemies = new GameObject[]; pas besoin de cette ligne puique les arrays seront remplis en SerializeField
    }

    public void Spawn()
    {
        var enemy = PickEnemy();
        var spawner = PickSpawn();
        Instantiate(enemy, spawner.transform.position, Quaternion.identity);
    }

    public GameObject PickEnemy()
    {
        return enemies[Random.Range (0, enemies.Length)];
    }

    public GameObject PickSpawn()
    {
        return spawners[Random.Range (0,spawners.Length)];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
