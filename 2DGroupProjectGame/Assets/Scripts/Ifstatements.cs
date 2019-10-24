using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ifstatements : MonoBehaviour
{
    public float coffeetemp = 170.0f;
    float hotlimit = 180.0f;
    float coldlimit = 110.0f;

    // Update is called once per frame
    void Update()
    {
        coffeetemp -= Time.deltaTime * 5;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
    }
    void TemperatureTest()
    {
        if(coffeetemp > hotlimit)
        {
            Debug.Log("Yikes! That hurt my tongue");
        }
        else if(coffeetemp < coldlimit)
        {
            Debug.Log("Ack. That's real cold");
        }
        else
        {
            Debug.Log("Ahhh thats good coffee");
        }
    }
}
