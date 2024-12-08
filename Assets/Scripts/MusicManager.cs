using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource.loop = true;
        audioSource.Play();
    }
}
