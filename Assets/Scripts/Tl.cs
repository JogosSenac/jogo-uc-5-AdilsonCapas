using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tl : MonoBehaviour
{
    public float scrollSpeed = 2f;
    public float mapWidth = 4f; 

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        if (transform.position.x < startPosition.x - mapWidth)
        {
            Vector3 newPosition = startPosition;
            newPosition.x += mapWidth * 2;
            transform.position = newPosition;
        }
    }
}
