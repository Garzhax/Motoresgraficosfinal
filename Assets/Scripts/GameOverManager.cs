using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    // Declara la variable para el Canvas de Game Over
    public GameObject gameOverCanvas;  // Asegúrate de asignar el Canvas de Game Over en el inspector

    // Detecta la colisión con el jugador
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto con el que colisiona es el jugador
        if (other.CompareTag("Player"))
        {
            // Activa el Canvas de Game Over
            if (gameOverCanvas != null)
            {
                gameOverCanvas.SetActive(true);
            }

            // Detiene el tiempo del juego cuando aparece el Game Over
            Time.timeScale = 0f;
        }
    }
}
