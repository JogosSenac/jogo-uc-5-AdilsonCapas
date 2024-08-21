using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public Transform player; // Referência ao jogador
    public float speed = 4f;
    public float stopDistance = 1.5f; // Distância mínima para parar de perseguir

    private Collider2D enemyCollider;

    void Start()
    {
        enemyCollider = GetComponent<Collider2D>();

        // Ignorar colisões entre o inimigo e os obstáculos
        Collider2D[] obstacleColliders = FindObjectsOfType<Collider2D>();
        foreach (Collider2D obstacleCollider in obstacleColliders)
        {
            if (obstacleCollider.CompareTag("Obs"))
            {
                Physics2D.IgnoreCollision(enemyCollider, obstacleCollider);
            }
        }
    }

    private void Update()
    {
        // Se o jogador estiver a uma distância maior que a stopDistance
        if (Vector2.Distance(transform.position, player.position) > stopDistance)
        {
            // Move o inimigo na direção do jogador
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Se o inimigo colidir com o jogador
        if (other.gameObject.CompareTag("Player"))
        {
            // Lógica ao colidir com o jogador
            Debug.Log("Inimigo colidiu com o jogador!");
            // Adicionar lógica de dano ou qualquer outra ação
        }
    }
}
