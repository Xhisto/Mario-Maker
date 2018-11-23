using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int amount = 1;

    public float spinspeed = 180;

    private void Update()
    {
        transform.Rotate(0, spinspeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
