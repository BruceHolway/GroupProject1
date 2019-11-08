using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHP : MonoBehaviour
{
    private Animator anim;
    public int health = 50;
    public Text HP;
    public Slider Healthslider;
    public int lives = 0;
    public float deathTime;
    private float deathTimeCounter;

    private void Start()
    {
        HP.text = "Health: " + health;
        Healthslider.maxValue = health;
        Healthslider.value = health;
        lives = PlayerPrefs.GetInt("lives");
        anim = GetComponent<Animator>();
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
                
                        deathTimeCounter = deathTime;
                        anim.SetBool("Death", true);
                
                }
                if(deathTimeCounter > 0)
                {
                    deathTimeCounter -= Time.deltaTime;
                }
                else
                {
                    SceneManager.LoadScene("Death");
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

                deathTimeCounter = deathTime;
                anim.SetBool("Death", true);

            }
            if (deathTimeCounter > 0)
            {
                deathTimeCounter -= Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene("Death");
            }
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Health")
        {
            {
                health = health + 10;
                HP.text = "Health: " + health;
                Healthslider.value = health;
                Destroy(collision.gameObject);
                if (health > 101)
                {
                    {
                        SceneManager.LoadScene("Death2");
                    }
                }
            }
        }
    }

}

    
