using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel; // Referencia al panel de Game Over

    void Start()
    {
        gameOverPanel.SetActive(false); // Aseg�rate de que el panel est� desactivado al inicio
    }

    public void ShowGameOverScreen()
    {
        gameOverPanel.SetActive(true); // Muestra el panel de Game Over
    }

    public void RetryGame()
    {
        // Carga la escena del men� inicial
        SceneManager.LoadScene("MenuInicial"); // Cambia "MenuInicial" por el nombre exacto de tu escena
    }

    public void ExitGame()
    {
        // Muestra un mensaje de depuraci�n al salir
        Debug.Log("Bot�n de salir presionado.");
        Application.Quit(); // Cierra la aplicaci�n
    }
}
