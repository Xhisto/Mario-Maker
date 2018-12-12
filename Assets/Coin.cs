using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int amount = 1;
    public static int score;
    // static gör så att det variabeln gäller alla scripts och kan läggas till i en annan script.
    public float spinspeed = 180;

    private void Update()
    {
        // objektet roterar på sin Y axel och i realtid istället för fps.
        transform.Rotate(0, spinspeed * Time.deltaTime, 0);
    }
    // ontriggerenter2D är som collision2D, men hitboxen går att gå igenom. istället för när man rör så är det när man är i hitbox zonen.
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        // gör så att ifall det visade tagen kolliderar med det valda objectet, förstör det och adderas till Coin scoren.
        if (collision.tag == "Player")
        {
            Coin.score += amount;
            Destroy(gameObject);
        }
    }
}
