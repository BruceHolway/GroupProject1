using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator anim;
    public float moveSpeed = 5.0f;
    public float attackTime;
    private float attackTimeCounter;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 velocity = new Vector2(x, y);
        GetComponent<Rigidbody2D>().velocity = velocity * moveSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 8;
        }
        else
        {
            moveSpeed = 5;
        }
        if (Input.GetButton("Fire1"))
        {
            attackTimeCounter = attackTime;
            anim.SetBool("Attack", true);
        }
        if(attackTimeCounter > 0)
        {
            attackTimeCounter -= Time.deltaTime;
            Debug.Log("foo");
        }
        else
        {
            anim.SetBool("Attack", false);
        }
    }
   
}
