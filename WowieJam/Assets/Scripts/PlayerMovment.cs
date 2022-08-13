using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody2D rb;

    [HideInInspector]public Vector2 playerInput;
    public float speed = 100f;
    public float jumpForce = 100f;
    
    [SerializeField] private Transform firstPoint;
    [SerializeField] private float raycastDistance;
    
    
    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.x > 8 || rb.velocity.x < -8)
        {
            rb.velocity = new Vector2(rb.velocity.x * 0.9f, rb.velocity.y);
        }
        


        playerInput.x = Input.GetAxisRaw("Horizontal");

        if(Input.GetButtonDown("Jump")&& IsGrounded())
        {
            rb.AddForce(Vector2.up * jumpForce);
        }

        rb.AddForce(playerInput*speed*Time.deltaTime);
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.Raycast(firstPoint.position, Vector2.down, raycastDistance, LayerMask.GetMask("Ground"));
        if(raycastHit2D.collider != null)
        {
            return true;
        }else
        {
            return false;
        }
    }
}
