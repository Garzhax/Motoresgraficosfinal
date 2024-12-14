using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Variable para definir la velocidad de la bala
    public float speed = 20f;

    // Variable para definir cuánto tiempo vive la bala antes de destruirse automáticamente
    public float lifeTime = 2f;

    private void Start()
    {
        // Destruir la bala automáticamente después de un tiempo para optimizar recursos
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        // Hacer que la bala se mueva hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Si la bala colisiona con un enemigo
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Incrementar el contador de enemigos eliminados en el GameManager
            GameManager.enemiesDestroyed++;

            // Destruir al enemigo
            Destroy(collision.gameObject);
        }

        // Destruir la bala en cualquier caso de colisión
        Destroy(gameObject);
    }
}
