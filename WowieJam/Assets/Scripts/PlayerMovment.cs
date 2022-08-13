using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody2D rb;

    [HideInInspector]public Vector2 playerInput;
    public float speed = 100f;
    
    
    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.x > 8 || rb.velocity.x < -8)
        {
            rb.velocity = new Vector2(rb.velocity.x * 0.9f, rb.velocity.y);
        }
        


        playerInput.x = Input.GetAxisRaw("Horizontal");


        rb.AddForce(playerInput*speed*Time.deltaTime);
    }
}
