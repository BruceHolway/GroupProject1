using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoinCollectAndAddHP : MonoBehaviour
{
    public int Coin = 0;
    public int goal;
    public Text cointext;
    public string player;

    void Start()
    {
        cointext.text = "COINS " + Coin + "/" + goal;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "coin")
        {
            Coin++;
            GameObject.Find(player).GetComponent<PlayerHPReferencable>().health++;
            GameObject.Find(player).GetComponent<PlayerHPReferencable>().Healthupdate();
            
            cointext.text = "coins " + Coin + "/" + goal;
            Destroy(collision.gameObject);
            if (Coin > goal - 1)
            {
                SceneManager.LoadScene("win");
            }
        }
        
    }
}

