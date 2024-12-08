using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public Transform player;             
    public float minSpawnInterval = 1f;  
    public float maxSpawnInterval = 3f;  
    public float spawnDistanceAhead = 10f; 
    public float spawnRangeX = 5f;      
    public float intervalDecreaseRate = 0.1f; 

    private float timeSinceLastSpawn;
    private float currentSpawnInterval;
    private float timeElapsed;

    void Start()
    {
        currentSpawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        timeElapsed += Time.deltaTime;

        if (timeSinceLastSpawn >= currentSpawnInterval)
        {
            SpawnObstacle();
            timeSinceLastSpawn = 0f;

            currentSpawnInterval = Mathf.Max(minSpawnInterval, currentSpawnInterval - intervalDecreaseRate * Time.deltaTime);
        }
    }

    void SpawnObstacle()
    {
        GameObject obstaclePrefab = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];

        float spawnX = player.position.x + spawnDistanceAhead;
        float randomXOffset = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(spawnX + randomXOffset, transform.position.y, transform.position.z);

        GameObject newObstacle = Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);

        float randomScale = Random.Range(0.5f, 1.5f);
        newObstacle.transform.localScale = new Vector3(randomScale, randomScale, 1f);
    }
}
