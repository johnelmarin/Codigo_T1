using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaController : MonoBehaviour
{
    public float velocityX = 10;
    public float jumpForce = 35;

    private Rigidbody2D rb;
   

    private Animator _animator;

    private bool isSlide = false;
    private bool isDead = false;

    private const int ANIMATION_JUMP = 1;


    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();

    }

    
    void Update()
    {
        if (!isDead)
        {
            isSlide = false;
            Debug.Log(velocityX);
            rb.velocity = new Vector2(velocityX, rb.velocity.y);
            _animator.SetInteger("Estado", 0);
            if (Input.GetKeyUp(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                changeAnimation(ANIMATION_JUMP);
            }
            
        }

        



    }

    private void OnCollisionEnter2D(Collision2D other)
    {
       
        if (other.gameObject.CompareTag("Zombie"))
        {
            Debug.Log("Morir");
            isDead = true;
            _animator.SetInteger("Estado", -1);
            
        }
    }


    private void changeAnimation(int animation)
    {
        _animator.SetInteger("Estado", animation);
    }
}


