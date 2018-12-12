using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialNextLevel : MonoBehaviour
{
    public string scenetoload;
    void OnTriggerEnter2D(Collider2D collision)
    {// om det rör tagen "player" och man har 1 score, ladda nästa fixerade bana.
        if (collision.tag == "Player" && Coin.score == 1f)
        {
            SceneManager.LoadScene(scenetoload);
            Coin.score = 0;
        }
    }
}
