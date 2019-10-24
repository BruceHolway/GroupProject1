using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyaitopdown : MonoBehaviour
{
    public float tolerence = 0.1f;
    public float chasespeed = 1.25f;
    public float pacespeed = 1;
    public float range = 2.5f;
    float timer = 0;
    public Transform player;
    Vector3 startpos;
    bool home = true;
    public Vector3 pacedir;
    public float pacedist = 3f;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
        pacedir.Normalize();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Vector2 homedir = new Vector2(startpos.x - transform.position.x, startpos.y - transform.position.y);
        Vector2 playerdir = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        if (playerdir.magnitude < range)
        {
            Chaseplayer();
        }
        else if (!home)
        {
            Gohome();
        }
        else
        {
            Pace();
        }
    }

    void Chaseplayer()
    {
        home = false;
        Vector2 chasedir = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        chasedir.Normalize();
        transform.up = chasedir;
        GetComponent<Rigidbody2D>().velocity = chasedir * chasespeed;

    }
    void Gohome()
    {
        Vector2 homedir = new Vector2(startpos.x - transform.position.x, startpos.y - transform.position.y);
        if (homedir.magnitude < tolerence)
        {
            transform.position = startpos;
            home = true;
        }
        else
        {
            homedir.Normalize();
            transform.up = homedir;
            GetComponent<Rigidbody2D>().velocity = homedir * pacespeed;
        }
    }
    void Pace()
    {
        Vector3 disp = transform.position - startpos;
        timer += Time.deltaTime;
        if (disp.magnitude >= pacedist)
        {
            pacedir = -disp;
        }
        pacedir.Normalize();
        transform.up = pacedir;
        GetComponent<Rigidbody2D>().velocity = pacedir * pacespeed;
    }
}
