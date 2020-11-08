using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    
    [SerializeField]
    private TextMeshProUGUI scoreText;
    [SerializeField]
    private TextMeshProUGUI HpText;
    private GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindObjectOfType<GameManager>();
        scoreText = GetComponent<TextMeshProUGUI>();
        HpText = GetComponent<TextMeshProUGUI>();
        manager.Health = 3;
        manager.Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = manager.Score.ToString();
        HpText.text = manager.Health.ToString();
    }
}
