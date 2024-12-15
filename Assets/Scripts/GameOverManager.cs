using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    // M�todo para reiniciar el juego
    public void Retry()
    {
        // Carga la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // M�todo para salir del juego
    public void Exit()
    {
        // Si est�s en el editor de Unity, detiene la reproducci�n
            UnityEditor.EditorApplication.isPlaying = false;

        // Si est� en una compilaci�n final, cierra la aplicaci�n
        Application.Quit();
    }
}
