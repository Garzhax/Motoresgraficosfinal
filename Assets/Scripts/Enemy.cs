using UnityEngine;

public class Enemy : MonoBehaviour
{
    private bool isDestroyed = false;  // Evita que el enemigo sea destruido m�s de una vez

    void OnDestroy()
    {
        if (isDestroyed) return;  // Si ya se ha destruido, no hace nada
        isDestroyed = true;

        // Llama al GameManager solo cuando realmente se destruye
        GameManager gameManager = FindObjectOfType<GameManager>();
        if (gameManager != null)
        {
            gameManager.EnemyDestroyed();
        }
    }
}
