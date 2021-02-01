using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject gameOverScreen;
    void Start()
    {
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (player.transform.position.y < -20)
        {
            GameOver();
        }
    }
    void GameOver()
    {
        Time.timeScale = 0f;
        gameOverScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
