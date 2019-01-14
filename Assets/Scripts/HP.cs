using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{// static betyder att detta variablet gälls för alla skripts så länge man länkar namnen
    public static float currentHealth = 3f;
    // om jag är i en enemy, förlora 0.5 hälsa.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            currentHealth -= 0.5f;
        }
        // om jag har 0 I hälsa eller om jag rör något med tagen Trap, set score till 0, currentHealth till 3 och ladda om det aktiva scenen.
        if (currentHealth == 0f || collision.tag == "Trap")
        {
            HP.currentHealth = 3;
            Coin.score = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
