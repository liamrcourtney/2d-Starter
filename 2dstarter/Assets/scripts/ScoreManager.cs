using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;
   
    private GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindObjectOfType<GameManager>();
        scoreText = GetComponent<TextMeshProUGUI>();
        manager.Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = manager.Score.ToString();
    }
}
