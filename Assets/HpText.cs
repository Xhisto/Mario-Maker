using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpText : MonoBehaviour
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
        // Fixar så att texten i text UI skriver ut hp variabeln från HP scriptet.
        text.text = string.Format("Health: {0:0}", HP.currentHealth);

    }
}
