using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideText : MonoBehaviour
{
    

    private void Start()
    {
        GetComponent<Text>().enabled = true;
    }

    private void Update()
    {
        if(Coin.score >= 10f)
        {
            GetComponent<Text>().enabled = false;

        }

    }
}
