using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHARACTERSELECT : MonoBehaviour
{
    public string Character;

    public void DAVE()
    {
        Character = "dave";
        PlayerPrefs.SetString("character", Character);
    }
    public void FJORD()
    {
        Character = "fjord";
        PlayerPrefs.SetString("character", Character);
    }
    public void KAREN()
    {
        Character = "karen";
        PlayerPrefs.SetString("character", Character);
    }
    public void TBD()
    {
        Character = "tbd";
        PlayerPrefs.SetString("character", Character);
    }
}
