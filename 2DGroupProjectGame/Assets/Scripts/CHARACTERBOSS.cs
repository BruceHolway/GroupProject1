using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHARACTERBOSS : MonoBehaviour
{
    public bool spawned = false;
    public GameObject davebossprefab;
    public GameObject fjordbossprefab;
    public GameObject karenbossprefab;
    public GameObject tbdbossprefab;
    public GameObject loadboss;
    public string Character;
    // Start is called before the first frame update
    void Start()
    {
        Character = PlayerPrefs.GetString("character");
        if (Character == "dave")
        {
            GameObject loadboss = davebossprefab;
        }
        else if (Character == "fjord")
        {
            GameObject loadboss = fjordbossprefab;
        }
        else if (Character == "karen")
        {
            GameObject loadboss = karenbossprefab;
        }
        else if (Character == "tbd")
        {
            GameObject loadboss = tbdbossprefab;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && spawned == false)
        {
            spawned = true;
            GameObject boss = Instantiate(loadboss, transform.position, Quaternion.identity);
            Debug.Log("owo");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("owo");
        }
    }
}
