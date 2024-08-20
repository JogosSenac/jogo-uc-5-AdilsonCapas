using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TlLoop : MonoBehaviour
{
    public float mapWidth = 20f; // Largura do seu Tilemap

    void Update()
    {
        if (transform.position.x < -mapWidth)
        {
            Vector3 newPosition = transform.position;
            newPosition.x += mapWidth * 2;
            transform.position = newPosition;
        }
    }
}
