using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject prefab;
    public float bspee = 10f;
    public float bulletlifetime = 2f;
    public float shhotdelay = 0.2f;
    float timer = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(Input.GetButton("Fire1") && timer > shhotdelay)
        {
            
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector3 mousePosition = Input.mousePosition;
            Debug.Log("Mouse Position 1: " + mousePosition);
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Debug.Log("Mouse Position 1: " + mousePosition);
            Vector2 shootdire = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
            shootdire.Normalize();            
            bullet.GetComponent<Rigidbody2D>().velocity = shootdire * bspee;
            Destroy(bullet, bulletlifetime);
            timer = 0f;
            


        }
    }
}
