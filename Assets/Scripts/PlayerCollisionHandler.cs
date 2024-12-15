using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    public GameOverManager gameOverManager; // Referencia al GameOverManager

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) // Si colisiona con un enemigo
        {
            gameOverManager.ShowGameOverScreen(); // Llama al método para mostrar la pantalla de Game Over
        }
    }
}
