using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseLevel : MonoBehaviour
{

    // Use this for initialization

    public int minimumScoreNeeded = 0;
    public string SceneToLoad = "First";

    // ifall PLayer rör det bestämda trigger och Coin scoren är mer än minimum Score så kommer spelet ladda om banan med Score = 0
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Coin.score >= minimumScoreNeeded)
        {
            Coin.score = 0;
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}
