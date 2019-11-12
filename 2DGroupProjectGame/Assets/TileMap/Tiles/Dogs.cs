using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dogs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            Destroy(gameObject);
        }
        if (Input.GetKey(KeyCode.H))
        {
            SceneManager.LoadScene("Meme");
        }
        if (Input.GetKey(KeyCode.C))
        {
            SceneManager.LoadScene("HowToPlay");
        }
    }

}
