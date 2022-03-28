using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int scoreCount;
    public GameObject gameOver;
    public GameObject menuItems;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        scoreCount++;
        scoreText.text = $"Coins: {scoreCount}";
    }

    public void PlayerDie()
    {
        gameOver.SetActive(true);
        menuItems.SetActive(true);
        Time.timeScale = 0;
    }
}
