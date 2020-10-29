using System.Collections;
using UnityEngine;

public class walkingdino : MonoBehaviour
{

    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Character speed: " + speed);
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
    }

    void MoveCharacter()
    {
        float x = Input.GetAxis("Horizontal") * speed;

        
    }
}
