using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slimey : MonoBehaviour
{
    private GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindObjectOfType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.tag);
       

        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            manager.Health--;
            Debug.Log("Health: " + manager.Health);
        }
    }
}
