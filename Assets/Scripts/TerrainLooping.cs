using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainLoop : MonoBehaviour
{
    public GameObject[] terrainSegments;
    private float screenWidthInUnits;

    void Start()
    {
        screenWidthInUnits = Camera.main.orthographicSize * 2.0f * Screen.width / Screen.height;
    }

    void Update()
    {
        foreach (GameObject segment in terrainSegments)
        {
            if (segment.transform.position.x < -screenWidthInUnits)
            {
                Vector3 newPosition = segment.transform.position;
                newPosition.x += screenWidthInUnits * terrainSegments.Length;
                segment.transform.position = newPosition;
            }
        }
    }
}
