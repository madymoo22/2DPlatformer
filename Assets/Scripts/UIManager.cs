using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;

    void Start()
    {
        UpdateScore(GameManager.Instance.currentScore);
        UpdateHealth(GameManager.Instance.currentHealth);
    }
    
    void OnEnable()
    {
        GameManager.OnScoreChanged += UpdateScore;
        GameManager.OnHealthChanged += UpdateHealth;
        GameManager.OnGameOver += HandleGameOver;
    }

    void OnDisable()
    {
        GameManager.OnScoreChanged -= UpdateScore;
        GameManager.OnHealthChanged -= UpdateHealth;
        GameManager.OnGameOver -= HandleGameOver;
    }

    void UpdateScore(int newScore)
    {
        Debug.Log("Score updated: " + newScore);

        scoreText.text = "Score: " + newScore;
    }

    void UpdateHealth(int newHealth)
    {
        Debug.Log("Health updated: " + newHealth);

        healthText.text = "Health: " + newHealth;
    }

    void HandleGameOver()
    {
        Debug.Log("Game Over event triggered!");

        SceneManager.LoadScene("GameOver");
    }
}