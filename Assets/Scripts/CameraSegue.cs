using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSegue : MonoBehaviour
{
    public GameObject player;
    public Vector3 posInicial;
    public float limiteX1;
    public float limiteX2;
    public float limiteY1;
    public float limiteY2;

    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            if(player.transform.position.x >= limiteX1 && 
                player.transform.position.y <= limiteY1 && 
                    player.transform.position.x <= limiteX2 && 
                        player.transform.position.y >= limiteY2)
            {
                transform.position = new Vector3(
                                    player.transform.position.x,
                                    player.transform.position.y,
                                    -3);
            }
            
        }

        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            transform.position = posInicial;
        }
        
    }
}
