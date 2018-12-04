using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movespeed = 7f;
    public float jumpspeed = 15f;
    public int DoubleJumpValue = 0;

    private Rigidbody2D rbody;
    public GroundChecker Groundcheck;

    // Use this for initialization
    void Start()
    {
        // gör så att rbody variabeln är det valda Rigidbody
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // gör så att spelaren kan gå vänster och höger
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * movespeed, rbody.velocity.y);
        // ifall jag trycker ner hopp knappen och min hitbox rör något, du kan hoppa.
       
        if (Input.GetButtonDown("Jump") && Groundcheck.isGrounded == true)
        {
            DoubleJumpValue = 1;
            rbody.velocity = new Vector2(rbody.velocity.x, jumpspeed);        
        }
        if (Input.GetButtonDown("Jump") && DoubleJumpValue == 1 && Groundcheck.isGrounded == false)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpspeed);
            DoubleJumpValue = 0;
        }

    }
}
