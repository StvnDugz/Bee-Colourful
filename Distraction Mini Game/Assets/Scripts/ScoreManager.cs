using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    //public GameObject gameOverText;
    private Text scoreText;
    public bool gameOver = false;
    private int score = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        scoreText = GetComponent<Text>();
    }


    public void PlayerScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = score.ToString();
    }

    public void PlayerDied()
    {
        //gameOverText.SetActive(true);
        gameOver = true;
    }
}
