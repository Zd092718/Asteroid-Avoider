using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverHandler : MonoBehaviour
{
    [SerializeField] TMP_Text gameOverText;
    [SerializeField] ScoreSystem scoreSystem;
    [SerializeField] GameObject gameOverDisplay;
    [SerializeField] AsteroidSpawner asteroidSpawner;
    public void EndGame()
    {
        asteroidSpawner.enabled = false;

        int finalScore = scoreSystem.EndTimer();
        gameOverText.text = $"Your score: {finalScore}";

        gameOverDisplay.gameObject.SetActive(true);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
