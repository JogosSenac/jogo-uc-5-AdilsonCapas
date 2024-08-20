using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tl : MonoBehaviour
{
    public float scrollSpeed = 2f; // Velocidade de movimento do Tilemap
    public float mapWidth = 4f;   // Largura do Tilemap (deve ser a largura total do Tilemap)

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position; // Armazena a posição inicial do Tilemap
    }

    void Update()
    {
        // Move o Tilemap para a esquerda
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        // Se o Tilemap sair da tela pela esquerda, reposicione-o
        if (transform.position.x < startPosition.x - mapWidth)
        {
            Vector3 newPosition = startPosition;
            newPosition.x += mapWidth * 2;
            transform.position = newPosition;
        }
    }
}
