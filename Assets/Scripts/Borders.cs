﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
            Application.LoadLevel(Application.loadedLevel);
    }
}