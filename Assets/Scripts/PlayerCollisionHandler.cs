using UnityEngine;


public class PlayerCollisionHandlerS : MonoBehaviour
{
    private GameOverManager gameOverManager;

    private void Start()
    {
        gameOverManager = FindObjectOfType<GameOverManager>();  // Encuentra el GameManager
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (gameOverManager != null)
            {
                gameOverManager.ShowGameOverScreen();  // Muestra el Game Over Panel
            }
        }
    }
}
