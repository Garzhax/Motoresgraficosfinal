using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Cuando la bala colisiona con algo
    private void OnCollisionEnter(Collision collision)
    {
        // Verificamos si la bala chocó con un enemigo (puedes usar el tag de tu enemigo)
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destruimos al enemigo
            Destroy(collision.gameObject);
            // Destruimos la bala
            Destroy(gameObject);
        }
    }
}
