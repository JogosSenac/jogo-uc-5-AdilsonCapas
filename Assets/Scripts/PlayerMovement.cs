using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public TMP_Text Moedas;

    public int moeda = 0;
    public float speed = 5f;
    public float jumpForce = 10f;
    public int maxLives = 2;

    private int currentLives;
    private Rigidbody2D rb;
    private Animator animator;

    void UpdateMoeda()
    {
        Moedas.text = "Moedas: " + moeda.ToString();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        currentLives = maxLives;
    }

    void Update()
    {
        
       
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obs"))
        {
            Vector2 contactPoint = collision.GetContact(0).point;
            Vector2 center = collision.collider.bounds.center;

            bool isSideCollision = Mathf.Abs(contactPoint.y - center.y) < Mathf.Abs(contactPoint.x - center.x);
        }
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Morte");
        }

    }

    void SalvarDados()
    {
        PlayerPrefs.SetInt("Moeda", moeda);
        PlayerPrefs.Save();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Moeda"))
        {
            Destroy(other.gameObject);
            moeda++;
            UpdateMoeda();
            SalvarDados();
        }
    }
    
}
