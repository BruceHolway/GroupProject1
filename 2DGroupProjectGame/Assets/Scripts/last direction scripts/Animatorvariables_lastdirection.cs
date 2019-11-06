using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatorvariables_lastdirection : MonoBehaviour
{
    public float lastdirection;
    // Start is called before the first frame update
    void Start()
    {
        lastdirection = 0;
        GetComponent<Animator>().SetFloat("lastdirection", lastdirection);
    }
    //noah
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        GetComponent<Animator>().SetFloat("x", x);
        GetComponent<Animator>().SetFloat("y", y);
        if (x == -1)
        {
            if (y == -1)
            {
                lastdirection = 2.5f;
            }
            else if (y == 1)
            {
                lastdirection = 3.5f;
            }
            else if (y == 0)
            {
                lastdirection = 3;
            }
        }
        else if (x == 1)
        {
            if (y == -1)
            {
                lastdirection = 0.5f;
            }
            else if (y == 1)
            {
                lastdirection = 1.5f;
            }
            else if (y == 0)
            {
                lastdirection = 1;
            }
        }
        else if (x == 0)
        {
            if (y == -1)
            {
                lastdirection = 0;
            }
            else if (y == 1)
            {
                lastdirection = 2;
            }
            
        }
        GetComponent<Animator>().SetFloat("lastdirection", lastdirection);
    }
}
