using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;  // Referencia al panel de Game Over

    void Start()
    {
        gameOverPanel.SetActive(false);  // Aseg�rate de que el panel est� desactivado al inicio
    }

    public void ShowGameOverScreen()
    {
        gameOverPanel.SetActive(true);  // Muestra el panel de Game Over
    }

    public void RetryGame()
    {
        // Vuelve a cargar la escena actual
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        // Sale del juego
        Application.Quit();
    }
}
