using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlusMinus : MonoBehaviour
{
    public int score = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Plus")
        {
            score++;
            if(score > 10)
            {
                SceneManager.LoadScene(1);
            }
        }else if (collision.gameObject.tag == "Minus")
        {
            score--;
            if(score < -10)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
