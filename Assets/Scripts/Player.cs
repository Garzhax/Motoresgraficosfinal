using UnityEngine;

public class Player : MonoBehaviour
{
    public GameOverManager gameOverManager; // Referencia a GameOverManager

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) // Si colisiona con un enemigo
        {
            gameOverManager.ShowGameOverScreen(); // Muestra la pantalla de Game Over
        }
    }
}
