using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseLevel : MonoBehaviour
{

    // Use this for initialization

    public string SceneToLoad;

    // ifall PLayer rör det bestämda trigger och min hälsa är 0, ladda om det fixade banan, mitt hp blir till 3 och min score till 0.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && HP.currentHealth == 0f)
        {
            HP.currentHealth = 3;
            Coin.score = 0;
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}
