using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemydeath : MonoBehaviour
{
    public int hp = 3;
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
        if(collision.gameObject.tag == "bullet")
        {
            hp--;
            if(hp < 1)
            {
                Destroy(gameObject);
            }
        }
     }
}
