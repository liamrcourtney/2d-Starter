using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

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

    void Start()
    {
     //   Debug.Log("Speed: " + speed);
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        halfHeight = (GetComponent<SpriteRenderer>().bounds.size.y / 2) + 0.1f;
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
            //animator.Play("idleChar");
             animator.Play("running");
            if ((movementX > 0 && scale.x < 0) || (movementX < 0 && scale.x > 0))
            {
                scale.x *= -1;
                transform.localScale = scale;
            }
        }
        else
        {
            //animator.Play("running");
            animator.Play("idleChar");
        }
    }
    
    void Jump()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            RaycastHit2D hit2D = Physics2D.Raycast(transform.position, Vector2.down, 3f, Ground);
            if (hit2D && hit2D.distance < halfHeight)
            {
                rigidBody.velocity = new Vector3(0, vSpeed);

            }
            animator.Play("jumping");
          
            //if ((movementX > 0 && scale.x < 0) || (movementX < 0 && scale.x > 0))
            //{
            //    scale.x *= -1;
            //    transform.localScale = scale;
            //}
        }
        else
        {
            animator.Play("idleChar");
        }
    } 
}
