using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHP : MonoBehaviour
{
    public int health = 50;
    public Text HP;
    public Slider Healthslider;
    public int lives = 0;

    private void Start()
    {
        HP.text = "Health: " + health;
        Healthslider.maxValue = health;
        Healthslider.value = health;
        lives = PlayerPrefs.GetInt("lives");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            {
                health = health - 10;
                HP.text = "Health: " + health;
                Healthslider.value = health;
                if (health < 1)
                {
                    {
                        SceneManager.LoadScene("Death");
                    }
                }
            }
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            HP.text = "Health: " + health;
            Healthslider.value = health;
            if (health < 1)
            { 
                {
                    SceneManager.LoadScene("Death");
                }
            }
        }

    }
    

}

    
