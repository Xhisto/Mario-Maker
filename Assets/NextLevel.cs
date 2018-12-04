using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string scenetoload;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Coin.score == 10f)
        {
            SceneManager.LoadScene(scenetoload);
        }
    }
}
