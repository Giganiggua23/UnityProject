using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class MoneyBank : MonoBehaviour
    {
    public static double cost = 30;
    public Text costText;
    

    public void OnBuy()
        {
        if (ClickHandler.score >= cost)
            {
            ClickHandler.score -= cost;
            ClickHandler.profit += 1;
            cost *= 1.5;
            cost = Math.Round(cost);
            }
        else
            {

            }
        }

    void FixedUpdate()
        {
        costText.text = "Upgrade cost: $" + cost.ToString();
        }
    }
