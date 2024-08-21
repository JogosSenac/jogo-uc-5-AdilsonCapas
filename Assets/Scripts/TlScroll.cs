using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TlScroll : MonoBehaviour
{
    public float scrollSpeed = 2f;

    void Update()
    {
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
    }
}
