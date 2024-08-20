using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSegue : MonoBehaviour
{
    /*
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
        
    }*/
     public Transform player;   // Referência ao Transform do jogador
    public float smoothSpeed = 0.125f;  // Velocidade de suavização da câmera
    public Vector3 offset;    // Distância da câmera em relação ao jogador

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 desiredPosition = player.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
