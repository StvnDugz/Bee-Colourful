using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;         // Creating an instance of the GameManger
    public bool gameOver = false;
    public float slowAmount = 10f;              // The amount of slow motion
    public GameObject levelFailedText;          // The text displaying that the level has been failed

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
        if (gameOver == false)
        {
            Debug.Log("Level Failed");
            gameOver = true;
            levelFailedText.SetActive(true);
            StartCoroutine(RestartLevel());
        }
    }

    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowAmount;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowAmount;

        yield return new WaitForSeconds(3.5f / slowAmount);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowAmount;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
