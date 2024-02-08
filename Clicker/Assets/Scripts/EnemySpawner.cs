using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
    {
    public GameObject enemyPref;
    public float minSpawnTime = 15;
    public float maxSpawnTime = 60;
    private float spawnTime = 0;

    void Awake()
        {
        setSpawnTime();
        }

    void FixedUpdate()
        {
        Debug.Log(spawnTime);
        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
            {
            Instantiate(enemyPref, transform.position, Quaternion.identity);
            setSpawnTime();
            }
        }
    private void setSpawnTime()
        {
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
