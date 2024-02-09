using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FarmingSim : MonoBehaviour
{
    public int coin = 0;       // coin


    void Update()
    {
        Farm();
        MineFarm();
        TreeFarm();
        FishFarm();
    }

    //----Farm----

    float timeFarm = 0;
    int costFarm = 1;
    int farmFarm = 0;


   


    void Farm()
    {
        timeFarm = timeFarm + Time.deltaTime;

        if (timeFarm >= 5)                 // time
        {
            coin += farmFarm;
            timeFarm = 0;
        }
    }
    public void OnClickBuyFarm()
    {
        int costF = 500 * costFarm;       //COSTFARM
        if (coin >= costF)
        {
            coin = coin - 1500 * costFarm;
            costFarm += 1;
            farmFarm += 10 * costFarm;                //how
            
        }
    }

    //----MineFarm----

    float timeMineFarm = 0;
    int costMineFarm = 1;
    int farmMineFarm = 0;





    void MineFarm()
    {
        timeMineFarm = timeMineFarm + Time.deltaTime;

        if (timeMineFarm >= 30)                 // time
        {
            coin += farmMineFarm;
            timeMineFarm = 0;
        }
    }
    public void OnClickBuyMineFarm()
    {
        int cost = 5000 * costMineFarm;         //costFARM
        if (coin >= cost)
        {
            coin = coin - cost;   
            costMineFarm += 1;
            farmMineFarm += 500 * costMineFarm;                //how

        }
    }


    //----TreeFarm----

    float timeTreeFarm = 0;
    int costTreeFarm = 1;
    int farmTreeFarm = 0;



    void TreeFarm()
    {
        timeTreeFarm = timeTreeFarm + Time.deltaTime;

        if (timeTreeFarm >= 90)                 // time
        {
            coin += farmTreeFarm;
            timeTreeFarm = 0;
        }
    }
    public void OnClickBuyTreeFarm()
    {
        int cost = 25000 * costTreeFarm;         //costFARM
        if (coin >= cost)
        {
            coin = coin - cost;
            costTreeFarm += 1;
            farmTreeFarm += 5000 * costTreeFarm;                //how

        }
    }

    //----FishFarm----

    float timeFishFarm = 0;
    int costFishFarm = 1;
    int farmFishFarm = 0;



    void FishFarm()
    {
        timeFishFarm = timeFishFarm + Time.deltaTime;

        if (timeFishFarm >= 120)                 // time
        {
            coin += farmFishFarm;
            timeFishFarm = 0;
        }
    }
    public void OnClickBuyFishFarm()
    {
        int cost = 70000 * costFishFarm;         //costFARM
        if (coin >= cost)
        {
            coin = coin - cost;
            costFishFarm += 1;
            farmFishFarm += 15500 * costFishFarm;                //how

        }
    }


}
