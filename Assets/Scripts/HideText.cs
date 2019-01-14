using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideText : MonoBehaviour
{


    private void Start()
    {// hitta det valda objectets text och det öppnade texten är aktiverad
        GetComponent<Text>().enabled = true;
    }

    private void Update()
    {// om coin score är mer eller lika med 10, stänga avaktivera det öppnade texten
        if (Coin.score >= 10f)
        {
            GetComponent<Text>().enabled = false;

        }

    }
}
