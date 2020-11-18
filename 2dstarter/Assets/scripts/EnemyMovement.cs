using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    public float enemySpeed;

    public bool RightMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RightMove)
        {
            transform.Translate(2 * Time.deltaTime * enemySpeed, 0, 0);
        }
        else 
        {
            transform.Translate(-2 * Time.deltaTime * enemySpeed, 0, 0);
        }
    }
}
