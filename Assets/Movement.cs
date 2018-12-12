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
        // Rigidbody varibeln är likamed det hittade rigidbody i det valda objectet
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // trycker man vänster höger pilen går man i det valda variabelns hastighet.
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * movespeed, rbody.velocity.y);

        // när jag trycker ner hopp knappen och min hitbox rör något, doublejumpvalue blir till 1 och du kan hoppa.       
        if (Input.GetButtonDown("Jump") && Groundcheck.isGrounded == true)
        {
            DoubleJumpValue = 1;
            rbody.velocity = new Vector2(rbody.velocity.x, jumpspeed);
        }
        // när jag trycker ner hopp knappen och min hitbox rör INTE något MEN double value är 1, hoppa igen och doublejumpvalue blir 0.
        if (Input.GetButtonDown("Jump") && DoubleJumpValue == 1 && Groundcheck.isGrounded == false)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpspeed);
            DoubleJumpValue = 0;
        }

    }
}
