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
    public float timer;
    string debug;
    bool stay = false;

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
            health = health - 10;
            HP.text = "Health: " + health;
            Healthslider.value = health;
            if (health < 1 && deathTimeCounter == 0)
            {
            
                deathTimeCounter = deathTime;
                anim.SetBool("Death", true);
            
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
            if (health < 1 && deathTimeCounter == 0)
            {

                deathTimeCounter = deathTime;
                anim.SetBool("Death", true);

            }
            
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Health")
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
        else if (collision.gameObject.tag == "radiation")
        {
            stay = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "radiation")
        {
            stay = false;
        }
    }

    public void Update()
    {
        timer += Time.deltaTime;
        if (deathTimeCounter > 0)
        {
            deathTimeCounter -= Time.deltaTime;
        }
        if(deathTimeCounter < 0)
        {
            anim.SetBool("Death", false);
            SceneManager.LoadScene("Death");
        }
        if (stay == true)
        {
            Slow_damage();
        }
    }

    public void Slow_damage()
    {
        
        
        if (timer >= 1)
        {
            health--;
            HP.text = "Health: " + health;
            Healthslider.value = health;
            timer = 0;
        }
    }
}

    
