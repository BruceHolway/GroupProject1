using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowingText : MonoBehaviour
{

    private bool showText = false, someRandomCondition = true;
    private float currentTime = 0.0f, executedTime = 0.0f, timeToWait = 5.0f;

    void OnMouseDown()
    {
        executedTime = Time.time;
    }

    void Update()
    {
        currentTime = Time.time;
        if (someRandomCondition)
            showText = true;
        else
            showText = false;

        if (executedTime != 0.0f)
        {
            if (currentTime - executedTime > timeToWait)
            {
                executedTime = 0.0f;
                someRandomCondition = false;
            }
        }
    }

    void OnGUI()
    {
        if (showText)
            GUI.Label(new Rect(0, 0, 100, 100), "Some Random Text");
    }
}
