﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSSSPAWNER : MonoBehaviour
{
    public GameObject loadboss;
    public bool spawned = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && spawned == false)
        {
            spawned = true;
            GameObject boss = Instantiate(loadboss, transform.position, Quaternion.identity);
            Debug.Log("uwu");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("uwu");
        }
    }
}
