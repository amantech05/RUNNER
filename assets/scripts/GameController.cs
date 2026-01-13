using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject gameoverpanel;
    public GameObject TaptoStart;
    public GameObject score;

    public void Start()
    {
        gameoverpanel.SetActive(false);
        TaptoStart.SetActive(true);
        score.SetActive(false);
        PauseGame();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    public void GameOver()
    {
        score.SetActive(false);
        gameoverpanel.SetActive(true);
        //Time.timeScale = 0f; // Pause the game
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //Time.timeScale = 1f; // Resume the game
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f; // Pause the game
    }

    public void StartGame()
    {
        TaptoStart.SetActive(false);
        score.SetActive(true);
        Time.timeScale = 1f; // Resume the game
    }
}
