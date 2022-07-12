using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;         // Creating an instance of the GameManger
    public Text scoreText;
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

    public void LevelFailed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        if (gameOver == false)
        {
            Debug.Log("Level Failed");
            gameOver = true;
        }
    }

    public void PlayerScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void PlayerDied()
    {
        //gameOverText.SetActive(true);
        gameOver = true;
    }
}
