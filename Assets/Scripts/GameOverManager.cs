using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    // Método para reiniciar el juego
    public void Retry()
    {
        // Carga la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Método para salir del juego
    public void Exit()
    {
        // Si estás en el editor de Unity, detiene la reproducción
            UnityEditor.EditorApplication.isPlaying = false;

        // Si está en una compilación final, cierra la aplicación
        Application.Quit();
    }
}
