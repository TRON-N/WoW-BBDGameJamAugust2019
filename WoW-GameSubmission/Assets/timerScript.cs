﻿using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timerScript : MonoBehaviour
{

    public float timeLeft = 10.0f;
    public Text startText; // used for showing countdown from 3, 2, 1
    public UIManager uiManager; 


    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = "Time Limit: " + (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            this.uiManager.EndGame("RED");
        }
    }
}