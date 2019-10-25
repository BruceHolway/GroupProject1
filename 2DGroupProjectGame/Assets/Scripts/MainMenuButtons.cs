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
        SceneManager.LoadScene("Settings");
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
    public void Troll()
    {
        SceneManager.LoadScene("Hardcore");
    }
    public void BruhMoment()
    {
        SceneManager.LoadScene("EasterEgg");
    }
}
