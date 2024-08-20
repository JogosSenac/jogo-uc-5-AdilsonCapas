using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    /*public Animator animPlayer;
    public SpriteRenderer sprite;
    public float moveH;
    public int velocidade;
    public int forcaPulo;
    private Rigidbody2D rb;
    public bool isJumping = false;
    public bool comVida = true;
    public int Money = 0;

    // Start is called before the first frame update
    void Start()
    {
        animPlayer = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate() 
    {
        //Andar
        moveH = Input.GetAxis("Horizontal"); // -1 a 1
        
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Animação Run para a direita e esqueda
        if(Input.GetKey(KeyCode.D))
        {
            animPlayer.SetLayerWeight(1,1);
            sprite.flipX = false;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            animPlayer.SetLayerWeight(1,1);
            sprite.flipX = true;
        }
        else
        {
            animPlayer.SetLayerWeight(1,0);
        }

        

        //Animação Pular
    if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(transform.up * forcaPulo,ForceMode2D.Impulse);
            isJumping = true;
        }
    }

     private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Chão"))
        {
            isJumping = false;
        }
    }*/
    public float speed = 5f;        // Velocidade de movimento do personagem
    public float jumpForce = 10f;   // Força do pulo

    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Captura a entrada de movimento horizontal (setas ou A/D)
        float moveInput = Input.GetAxisRaw("Horizontal");

        // Configura o movimento horizontal
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        // Atualiza o parâmetro isWalking baseado no movimento
        if (moveInput != 0)
        {
            animator.SetBool("Base Layer", true);
        }
        else
        {
            animator.SetBool("Base Layer", false);
        }

        // Controle do pulo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Obs"))
        {
           
        }
    }
    
}
