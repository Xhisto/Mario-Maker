﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTing : MonoBehaviour
{
    public float Speed = 10f;
    private Rigidbody2D rbody;
    public bool left = true;

    // Use this for initialization
    void Start()
    {
        // gör så att rbody variabeln är det valda Rigidbody
        rbody = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        // om enemi Ting går vänster, gå åt vänster. annars gå åt motsatsen av vänster.
        if (left == true)
        {
            rbody.velocity = -(Vector2)transform.right * Speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = (Vector2)transform.right * Speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {// om krockar med tagen "wall" gå åt andra vänster.
        if (collision.tag == "wall")
        {
            left = !left;
        }
    }
}
