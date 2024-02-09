using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
    {
    public GameObject enemy;
    public double health;
    public double damage = 1;
    public float speed = 2;

    public void Damage()
        {
        health -= damage;
        }

    void FixedUpdate()
        {
        if (health == 0)
            {
            Destroy(enemy);
            }
        }
    }
