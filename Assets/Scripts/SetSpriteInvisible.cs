﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // hitta renderer på valda objectet, det blir avaktiverade och aergo osynlig
        GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
