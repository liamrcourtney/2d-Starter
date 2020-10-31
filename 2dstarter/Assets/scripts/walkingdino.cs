using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingdino : MonoBehaviour
{
    public Vector2 movement;
    public Rigidbody2D rb;

   
    public float speed=5f;
    
    

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("Character speed: " + speed);
    }

    // Update is called once per frame
    void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal");
       
        //MoveCharacter();
    }

    void FixedUpdate()
    {
       // rb.MovePosition(rb.position + movement + speed + Time.fixedDeltaTime);
    }


   // void MoveCharacter()
    //{
    //    Input.GetAxisRaw("Horizontal") * speed;

        
    //}
}
