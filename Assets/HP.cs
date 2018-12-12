using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{// static betyder att detta variablet gälls för alla skripts så länge man länkar namnen
    public static float currentHealth = 3f;
    // om jag är i en enemy, förlora 1 hälsa.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            currentHealth -= 1f;
        }
    }
}
