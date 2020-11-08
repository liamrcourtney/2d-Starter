using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    private TextMeshPro scoreText;
    private GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindObjectOfType<GameManager>();    
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = manager.Score.ToString();
    }
}
