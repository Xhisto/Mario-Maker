using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Text text;
    // Use this for initialization
    void Start()
    {
        // hämtar Text UI till text variabeln
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // Fixar så att texten i text UI skriver ut score variabeln från Coin scriptet.
        text.text = string.Format("Score: {0:0000}", Coin.score);

    }
}
