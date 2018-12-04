using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class TutorialNextLevel : MonoBehaviour
{

    public string scenetoload;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Coin.score == 1f)
        {
            SceneManager.LoadScene(scenetoload);
            Coin.score = 0;
        }
    }
}
