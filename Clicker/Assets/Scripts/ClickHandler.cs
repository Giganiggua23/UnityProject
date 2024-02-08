using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ClickHandler : MonoBehaviour
    {
    public static double score = 0;
    public static double profit = 1;
    public Text scoreText;

    public void OnClick()
        {
        score = Math.Round(score);
        score += profit;
        }
    void FixedUpdate()
        {
        scoreText.text = "$ " + score.ToString();
        }
    }