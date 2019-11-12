using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public int lives = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("lives", lives);
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void Meme()
    {
        SceneManager.LoadScene("Meme");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Hardcore()
    {
        SceneManager.LoadScene("Hardcore");
    }
    public void EasterEgg()
    {
        SceneManager.LoadScene("EasterEgg");
    }
    public void CharacterSelect()
    {
        GetComponent<Canvas>().enabled = false;
        PlayerPrefs.SetInt("lives", lives);
        GameObject.Find("player select").GetComponent<Canvas>().enabled = true;
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
