using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel; // Referencia al panel de Game Over
    public GameObject player; // Referencia al jugador (o cualquier objeto que esté disparando)
    public MonoBehaviour[] playerScripts; // Lista de los scripts que controlan el movimiento y disparo del jugador
    public GameObject[] bullets; // Array de las balas que deben detenerse

    private bool isGameOver = false;

    void Start()
    {
        gameOverPanel.SetActive(false); // Asegúrate de que el panel esté desactivado al inicio
    }

    public void ShowGameOverScreen()
    {
        if (!isGameOver)
        {
            isGameOver = true; // Marca que el juego terminó
            gameOverPanel.SetActive(true); // Muestra el panel de Game Over

            // Pausa el juego
            Time.timeScale = 0f;

            // Detener los scripts del jugador (movimiento, disparo, etc.)
            foreach (var script in playerScripts)
            {
                script.enabled = false;
            }

            // Detener las balas (esto puede cambiar si usas un objeto distinto)
            foreach (var bullet in bullets)
            {
                bullet.SetActive(false); // Desactiva las balas
            }
        }
    }

    public void RetryGame()
    {
        Time.timeScale = 1f; // Reactiva el tiempo
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Vuelve a cargar la escena

        // Reactivar los scripts del jugador
        foreach (var script in playerScripts)
        {
            script.enabled = true;
        }
    }

    public void ExitGame()
    {
        Application.Quit(); // Cierra la aplicación
    }
}
