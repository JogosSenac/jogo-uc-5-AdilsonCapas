using UnityEngine;

public class Inimigo: MonoBehaviour
{
    /*public Transform jogador;  // Referência ao jogador
    public float velocidade = 2f;  // Velocidade de movimento do inimigo

    void Update()
    {
        // Verifica a direção em que o inimigo deve se mover
        Vector2 direcao = jogador.position - transform.position;
        
        // Normaliza a direção para manter a velocidade constante
        direcao.Normalize();
        
        // Move o inimigo na direção do jogador
        transform.position = Vector2.MoveTowards(transform.position, jogador.position, velocidade * Time.deltaTime);
    }*/
    public Transform player; // Referência ao jogador
    public float speed = 4f;
    public float stopDistance = 1.5f; // Distância mínima para parar de perseguir

    private void Update()
    {
        // Se o jogador estiver a uma distância maior que a stopDistance
        if (Vector2.Distance(transform.position, player.position) > stopDistance)
        {
            // Move o inimigo na direção do jogador
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }

    /*private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Obs"))
        {
            Destroy(other.gameObject);
        }
   }*/

}

