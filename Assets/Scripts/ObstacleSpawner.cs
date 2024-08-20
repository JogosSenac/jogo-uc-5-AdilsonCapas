using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab; // Prefab do obstáculo a ser instanciado
    public float spawnInterval = 2f;  // Intervalo de tempo entre as gerações
    public float spawnRangeX = 10f;   // A faixa de posições X onde os obstáculos serão gerados

    private float timeSinceLastSpawn;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnObstacle();
            timeSinceLastSpawn = 0f;
        }
    }

    void SpawnObstacle()
    {
        // Calcula uma posição aleatória fora da tela no eixo X
        float randomX = transform.position.x + Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, transform.position.z);

        // Instancia o obstáculo
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}

