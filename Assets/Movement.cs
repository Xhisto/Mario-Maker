using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movespeed = 7f;
    public float jumpspeed = 15f;

    private Rigidbody2D rbody;
    public GroundChecker Groundcheck;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * movespeed, rbody.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            if (Groundcheck.isGrounded == true)
            rbody.velocity = new Vector2(rbody.velocity.x, jumpspeed);

        }
    }
}
