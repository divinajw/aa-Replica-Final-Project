﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinScore;

    public Text text;

    void Start()
    {
        PinScore = 0;
    }

    void Update()
    {
        text.text = PinScore.ToString();
    }
}
