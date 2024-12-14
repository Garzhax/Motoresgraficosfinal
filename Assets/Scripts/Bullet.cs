using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Eliminar al enemigo
            Destroy(collision.gameObject);

            // Incrementar el contador de enemigos eliminados
            GameManager.enemiesDestroyed++;

            // Actualizar la UI
            FindObjectOfType<GameManager>().UpdateEnemiesCount();

            // Destruir la bala
            Destroy(gameObject);
        }
    }
}

