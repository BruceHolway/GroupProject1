using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHPReferencable: MonoBehaviour
{
    public int health;
    public int maxhp;
    public Text hptext;
    public Slider hpslider;
    public int lives;

    void Start()
    {
        lives = PlayerPrefs.GetInt("lives");
        hpslider.maxValue = maxhp;
        hpslider.value = health;
        hptext.text = "HP " + health + "/" + maxhp;
        GetComponent<Animator>().SetFloat("hp", health);
    }

    void Update()
    {
       if (health > maxhp)
        {
            health = maxhp;
            Healthupdate();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            hurt();
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy bullet")
        {
            hurt();
        }
    }
    public void hurt()
    {
        health--;
        GetComponent<Animator>().SetFloat("hp", health);
        Healthupdate();
        if (health < 1)
        {
            if (lives > 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                PlayerPrefs.SetInt("lives", lives - 1);
            }
            else
            {
                SceneManager.LoadScene("gameover");
            }
        }
    }
    public void Healthupdate()
    {
        hpslider.value = health;
        hptext.text = "HP" + health + "/" + maxhp;
    }
}
