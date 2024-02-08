using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Farm : MonoBehaviour
    {
    public static double farmProfit = 0;
    public Text farmProfitText;
    public static double farmUpgradeCost = 50;
    public Text farmUpgradeText;

    public void OnClickFarmUpgrade()
        {
            {
            if (ClickHandler.score >= farmUpgradeCost)
                {
                ClickHandler.score -= farmUpgradeCost;
                farmProfit += 2;
                farmProfit = Math.Round(farmProfit);
                farmUpgradeCost *= 1.5;
                farmUpgradeCost = Math.Round(farmUpgradeCost);
                }
            else
                {

                }
            }

        }

    double timeLeft = 1;
    void Update()
        {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
            {
            ClickHandler.score += farmProfit;
            timeLeft = 1;
            }
        }
    void FixedUpdate()
        {
        if (farmProfit == 0)
            {
            farmUpgradeText.text = "Построить ферму за: $ " + farmUpgradeCost.ToString() + "?";
            }
        else
            {
            farmUpgradeText.text = "Улучшить ферму за: $ " + farmUpgradeCost.ToString() + "?";
            }
        farmProfitText.text = "$ " + farmProfit.ToString();
        }
    }
