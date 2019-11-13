﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float chaseSpeed = 2.0f;
    public float paceSpeed = 1.5f;
    public float chaseTriggerDistance = 5.0f;
    Vector3 startPosition;
    bool home = true;
    public Vector3 paceDirection;
    public float paceDistance = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 chaseDirection = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        if(chaseDirection.magnitude <= chaseTriggerDistance)
        {
            chasePlayer();
        }
        else if (!home)
        {
            GoHome();
        }
        else
        {
            pace();
        }
    }
    void chasePlayer()
    {
        home = false;
        Vector2 chaseDirection = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        chaseDirection.Normalize();
        
        GetComponent<Rigidbody2D>().velocity = chaseDirection * chaseSpeed;
        
    }
    void GoHome()
    {
        Vector2 homeDirection = new Vector2(startPosition.x - transform.position.x, startPosition.y - transform.position.y);
        if(homeDirection.magnitude < 1)
        {
            transform.position = startPosition;
            home = true;
        }
        else
        {
            homeDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = homeDirection * paceSpeed;
        }
    }
    void pace()
    {
        Vector3 displacement = transform.position - startPosition;
        if(displacement.magnitude >= paceDistance)
        {
            paceDirection = -displacement;
        }
        paceDirection.Normalize();
        
        GetComponent<Rigidbody2D>().velocity = paceDirection * paceSpeed;            
    }
}
