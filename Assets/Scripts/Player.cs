using UnityEngine;

public class Player : MonoBehaviour
{
    private GameOverManager gameOverManager;  // Referencia al GameOverManager

    void Start()
    {
        gameOverManager = FindObjectOfType<GameOverManager>();  // Encuentra el GameOverManager
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Mostrar el Game Over cuando el jugador colisione con el enemigo
            gameOverManager.ShowGameOverScreen();
        }
    }
}
