using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_facing : MonoBehaviour
{
    public GameObject prefab;
    public float shootspeed = 10;
    public float bulletlife = 1;
    public float delay = 1.0f;
    float timer = 0;
    Vector2 shootdirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    //noah
    // Update is called once per frame
    void Update()
    {
        float direction = GetComponent<Animatorvariables_lastdirection>().lastdirection;

        timer += Time.deltaTime;
        
        if (direction >= 0 && direction < 0.5)
        {
            shootdirection = new Vector2(0, -1);
            Fire();

        }
        else if (direction >= 0.5 && direction < 1)
        {
            shootdirection = new Vector2(1, 0);
            Fire();

        }
        else if (direction >= 1 && direction < 1.5)
        {
            shootdirection = new Vector2(1, 0);
            Fire();

        }
        else if (direction >= 1.5 && direction < 2)
        {
            shootdirection = new Vector2(0, 1);
            Fire();

        }
        else if (direction >= 2 && direction < 2.5)
        {
            shootdirection = new Vector2(0, 1);
            Fire();

        }
        else if (direction >= 2.5 && direction < 3)
        {
            shootdirection = new Vector2(-1, 0);
            Fire();

        }
        else if (direction >= 3 && direction < 3.5)
        {
            shootdirection = new Vector2(-1, 0);
            Fire();

        }
        else if (direction >= 3.5 && direction < 3.5)
        {
            shootdirection = new Vector2(0, -1);
            Fire();

        }
    }

    public void Fire()
    {
        if (Input.GetButton("Fire1") && timer > delay)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            //Vector3 mouseposition = Input.mousePosition;
            //mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
            //Vector2 shootdirection = new Vector2(mouseposition.x - transform.position.x, mouseposition.y - transform.position.y);
            shootdirection.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootdirection * shootspeed;
            Destroy(bullet, bulletlife);
        }
    }
}
