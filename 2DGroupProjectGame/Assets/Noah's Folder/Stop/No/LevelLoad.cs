using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Level")
        {
            SceneManager.LoadScene("Meme");
        }
        if (collision.gameObject.tag == "Load")
        {
            SceneManager.LoadScene("EasterEgg");
        }
        if (collision.gameObject.tag == "Melon")
        {
            SceneManager.LoadScene("MelonLevel");
        }
        if (collision.gameObject.tag == "Dog")
        {
            SceneManager.LoadScene("Win2");
        }
    }
}
