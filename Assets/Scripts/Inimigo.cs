using UnityEngine;

public class Inimigo: MonoBehaviour
{
    public Transform jogador;  // Referência ao jogador
    public float velocidade = 2f;  // Velocidade de movimento do inimigo

    void Update()
    {
        // Verifica a direção em que o inimigo deve se mover
        Vector2 direcao = jogador.position - transform.position;
        
        // Normaliza a direção para manter a velocidade constante
        direcao.Normalize();
        
        // Move o inimigo na direção do jogador
        transform.position = Vector2.MoveTowards(transform.position, jogador.position, velocidade * Time.deltaTime);
    }
}

