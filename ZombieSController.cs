using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSController: MonoBehaviour
{
   

    private Rigidbody2D rb;
    public Vector2 speed = new Vector2(20, 20);
    private Vector2 movement = new Vector2(1, 1);

    private Animator animator;

    private bool isRun = false;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
    }

    
    void Update()
    {

        
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        movement = new Vector2(
            speed.x * inputX,
            speed.y * inputY);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
        }
       
    }

    void FixedUpdate()
    {
        
        rb.velocity = movement;
       
    }


}
