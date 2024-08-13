using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //A T E N Ç Ã O - CONSERTAR O CÓDIGO

    //Este personagem deve mover-se para a direita e esquerda, pular e coletar itens
    //O personagem deve ter uma animação de andar e idle
    //Ele deve morrar ao cair em um buraco

    public float moveH;
    public int velocidade;
    public int forcaPulo;
    private Rigidbody2D rb;
    private Animator animPlayer;
    private SpriteRenderer sprite;
    public bool isJumping = false;
    public bool comVida = true;
    public int Money = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
        //Animação Andar
        if(Input.GetKey(KeyCode.D) && moveH > 0)
        {
            sprite.flipX = false;
            animPlayer.SetLayerWeight(3,1);
        }
        else
        {
            animPlayer.SetLayerWeight(3,0);
        }
        if(Input.GetKey(KeyCode.A) && moveH < 0)
        {
            sprite.flipX = true;
            animPlayer.SetLayerWeight(3,1);
        }
        else
        {
            animPlayer.SetLayerWeight(3,0);
        }
    
        if(moveH == 0)
        {
        }
        
        if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(transform.up * forcaPulo,ForceMode2D.Impulse);
            isJumping = true;
        }
        /*else
        {
            animPlayer.SetLayerWeight(2,0)
        }

        if(!comVida)
        {
            SceneManager.LoadScene("Morte");
        }*/
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Chão"))
        {
            isJumping = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Buraco"))
        {
            Destroy(gameObject);
            comVida = false;
            SceneManager.LoadScene("Morte");
        }
        /*if(other.gameObject.CompareTag("Money"))
        {
            Destroy(other.gameObject);
            Money++;
        }*/

    }

    //Como faria se quisesse fazer o player morrer ao cair no buraco?
}