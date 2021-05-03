using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float currentTime;
    public GameObject enemyFactory;
    public GameObject[] enemyPos;
    int shootingTime; 

    void Start()
    {
        shootingTime = Random.Range(0, 3);
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (shootingTime <= currentTime) ShootingEnemy();
    }

    void ShootingEnemy()
    {
        GameObject item = Instantiate(enemyFactory);
        item.transform.position = enemyPos[shootingTime].transform.position;
        currentTime = 0;
        shootingTime = Random.Range(0, 3);
    }
}
