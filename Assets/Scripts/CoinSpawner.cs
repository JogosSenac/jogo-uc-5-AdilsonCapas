using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;            // Prefab da moeda a ser instanciada
    public Transform player;                 // Referência ao transform do jogador
    public float minSpawnInterval = 2f;      // Intervalo mínimo entre os spawns
    public float maxSpawnInterval = 4f;      // Intervalo máximo entre os spawns
    public float spawnDistanceAhead = 15f;   // Distância à frente do jogador para spawnar moedas
    public float spawnRangeX = 5f;           // Faixa de variação em X para spawn

    private float timeSinceLastSpawn;
    private float currentSpawnInterval;

    void Start()
    {
        // Definir o intervalo de spawn inicial aleatoriamente
        currentSpawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= currentSpawnInterval)
        {
            SpawnCoin();
            timeSinceLastSpawn = 0f;
            // Redefinir o intervalo de spawn para o próximo
            currentSpawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        }
    }

    void SpawnCoin()
    {
        // Calcula uma posição aleatória à frente do jogador
        float spawnX = player.position.x + spawnDistanceAhead;
        float randomXOffset = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(spawnX + randomXOffset, player.position.y, player.position.z);

        // Instancia a moeda
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }
}
