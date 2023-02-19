using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    private enum movementstate {idle,running,jumping,falling }
    
   
    [SerializeField] private float movespeed = 7f;
    [SerializeField] private float jumpspeed = 14f;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite=GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    private void Update()
    {
        movementstate state;
        float dirx = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirx * movespeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpspeed);

        }
        if (dirx > 0f)
        {
            state = movementstate.running;
            sprite.flipX = false;
        }
        else if (dirx < 0f)
        {
            state = movementstate.running;
            sprite.flipX=true;
        }
        else
        {
            state=movementstate.idle;


        }
        if (rb.velocity.y > .1f)
        {
            state = movementstate.jumping;
        }
        else if (rb.velocity.y < -.1f)
        { 
            state = movementstate.falling; 
        }
            anim.SetInteger("state", (int)state);
    }
}