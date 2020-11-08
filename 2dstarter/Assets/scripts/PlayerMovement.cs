﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    public float vSpeed;
    [SerializeField]
    private LayerMask Ground;
    private Rigidbody2D rigidBody;
    private float halfHeight;
    private Animator animator;
    private AudioClip iron;
    void Start()
    {
     //   Debug.Log("Speed: " + speed);
        rigidBody = GetComponent<Rigidbody2D>();
        halfHeight = (GetComponent<SpriteRenderer>().bounds.size.y / 2) + 0.1f;
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        MoveChar();
        Jump();

       
    }

    void MoveChar()
    {
        float movementX = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movementX * speed * Time.deltaTime, 0, 0);
        Vector3 scale = transform.localScale;
        if (movementX != 0)
        {
           
            if ((movementX > 0 && scale.x < 0) || (movementX < 0 && scale.x > 0))
            {
                scale.x *= -1;
                transform.localScale = scale;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.Play("running");
                       
        }
        else
        {
            animator.Play("idleChar");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.Play("running");

        }
        else
        {
            animator.Play("idleChar");
        }

    }
    
    void Jump()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            RaycastHit2D hit2D = Physics2D.Raycast(transform.position, Vector2.down, 3f, Ground);
                animator.Play("jumping");
            if (hit2D && hit2D.distance < halfHeight)
            {
                rigidBody.velocity = new Vector3(0, vSpeed);

            }

           
        }
        //else
        //{
        //    animator.Play("idleChar");
        //}
    } 

  
}
