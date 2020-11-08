using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ironCoins : MonoBehaviour
{
    private GameManager manager;
    [SerializeField]
    private AudioSource audioSource;

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
            audioSource.Play();
            Destroy(gameObject);
            manager.Score++;
            Debug.Log("Score: " + manager.Score);
        }

       
    }
}
