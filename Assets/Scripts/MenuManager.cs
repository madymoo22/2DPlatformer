using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadGameScene()
    {
        // Reset game values
        GameManager.Instance.currentScore = 0;
        GameManager.Instance.currentHealth = 100;

        SceneManager.LoadScene("GameScene");
    }
    
    public void QuitGame()
    {
        Application.Quit();
        // Quit only works in built games, not in the Unity Editor
    }
}