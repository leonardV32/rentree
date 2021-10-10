using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_behaviour : MonoBehaviour
{
    private Transform target;
    private GameObject player; // remplacer par l'avatar/player
    private float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Target");
        target = player.transform;
        float step = speed* Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step); // ici target.position deviendra Player.position
        
    }
}
