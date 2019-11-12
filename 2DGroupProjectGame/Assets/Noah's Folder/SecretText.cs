using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecretText : MonoBehaviour
{
    float timer;
    public Text Secret;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 50 && timer < 55)
        {
            Secret.text = "Why are you still here?";
        }
        else if (timer > 60 && timer < 65)
        {
            Secret.text = ". . .";
        }
        else if (timer > 70 && timer < 75)
        {
            Secret.text = "Just go play the game";
        }
        else if (timer > 80 && timer < 85)
        {
            Secret.text = ". . .";
        }
        else if (timer > 90 && timer < 95)
        {
            Secret.text = "Fun fact: if you play the game you play the game";
        }
        else if (timer > 100 && timer < 105)
        {
            Secret.text = "Your really just going to sit in the how to play screen?";
        }
        else if (timer > 110 && timer < 115)
        {
            Secret.text = ". . .";
        }
        else if (timer > 120 && timer < 125)
        {
            Secret.text = "Hey don't tell the devs but if you go to level one and press a button on the keybored a door will open";
        }
        else if (timer > 130 && timer < 135)
        {
            Secret.text = ". . .";
        }
        else if (timer > 150 && timer < 155)
        {
            Secret.text = "The button is one of the first few letters of one of the last names now get out of here before the devs get here";
        }
        else if (timer > 160 && timer < 165)
        {
            Secret.text = ". . .";
        }
        else if (timer > 170 && timer < 175)
        {
            Secret.text = "OH NO THEY ARE HERE AND YOU STILL HAVENT LEFT HURRY AND GO! RUN NOW!";
        }
        else if (timer > 180 && timer < 180)
        {
            Application.Quit();
        }
    }
}
