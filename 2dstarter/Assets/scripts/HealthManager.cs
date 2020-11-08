using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI HpText;
    private GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindObjectOfType<GameManager>();
        HpText = GetComponent<TextMeshProUGUI>();
        manager.Health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        HpText.text = manager.Health.ToString();
    }
}
