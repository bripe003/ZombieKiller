using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnTime = 6f;

    void Start()
    {
        InvokeRepeating("SpawnEnemies", 2, spawnTime);
        InvokeRepeating("SpawnEnemies", 20, 10);
        InvokeRepeating("SpawnEnemies", 40, 7);
    }
    void Update()
    {
        
    }
 
    void SpawnEnemies()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
    
}
