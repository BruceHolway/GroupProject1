using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CHARACTERSELECT : MonoBehaviour
{
    public string Character;

    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    public void DAVE()
    {
        Character = "dave";
        PlayerPrefs.SetString("character", Character);
        SceneManager.LoadScene("Level 1");
        
    }
    public void FJORD()
    {
        Character = "fjord";
        PlayerPrefs.SetString("character", Character);
        Debug.Log(PlayerPrefs.GetString("character"));
        SceneManager.LoadScene("Level 1");
        
    }
    public void KAREN()
    {
        Character = "karen";
        PlayerPrefs.SetString("character", Character);
        SceneManager.LoadScene("Level 1");
        
    }
    public void TBD()
    {
        Character = "tbd";
        PlayerPrefs.SetString("character", Character);
        SceneManager.LoadScene("Level 1");
        
    }
    public void MAINMENU()
    {
        GetComponent<Canvas>().enabled = false;
        GameObject.Find("main menu").GetComponent<Canvas>().enabled = true;
    }
}
