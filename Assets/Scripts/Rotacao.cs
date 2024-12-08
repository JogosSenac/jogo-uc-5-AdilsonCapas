using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{
    public float velocidadeRotacao = 100f;

    void Update()
    {
        transform.Rotate(0, 0, velocidadeRotacao * Time.deltaTime);
    }
}
