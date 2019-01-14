using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public int speed;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Åk -frammot i realtid. 
        transform.Translate(-speed * Time.deltaTime,0,0);
        // om objectet är i 22.53 x position, set x position i 31.02
        if (transform.position.x < 22.53f)
        {
            transform.position = new Vector3(31.02f, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om tagen är i objectets hitbox area, set x position i 31.02
        if (collision.tag == "Player")
        {
            transform.position = new Vector3(31.02f, transform.position.y, transform.position.z);
        }
    }
}
