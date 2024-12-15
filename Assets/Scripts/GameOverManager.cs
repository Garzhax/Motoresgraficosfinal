using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    private bool isGameOver = false;  // Estado del juego

    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    public void ShowGameOverScreen()
    {
        if (!isGameOver)
        {
            isGameOver = true;  // Marca que el juego terminó
            gameOverPanel.SetActive(true);
            // Opcional: Desactiva otros scripts aquí si es necesario
        }
    }

    public void RetryGame()
    {
        isGameOver = false;  // Reinicia el estado
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
