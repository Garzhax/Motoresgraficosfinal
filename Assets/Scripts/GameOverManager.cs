using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel; // Referencia al panel de Game Over

    void Start()
    {
        gameOverPanel.SetActive(false); // Asegúrate de que el panel esté desactivado al inicio
    }

    public void ShowGameOverScreen()
    {
        gameOverPanel.SetActive(true); // Muestra el panel de Game Over
    }

    public void RetryGame()
    {
        // Carga la escena del menú inicial
        SceneManager.LoadScene("MenuInicial"); // Cambia "MenuInicial" por el nombre exacto de tu escena
    }

    public void ExitGame()
    {
        // Muestra un mensaje de depuración al salir
        Debug.Log("Botón de salir presionado.");
        Application.Quit(); // Cierra la aplicación
    }
}
