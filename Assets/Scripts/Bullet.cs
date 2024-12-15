using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rb;

    private GameManager gameManager;

    private void Start()
    {
        rb.velocity = transform.forward * speed;
        gameManager = FindObjectOfType<GameManager>();  // Encuentra GameManager
    }

    private void OnTriggerEnter(Collider other) // Usamos OnTriggerEnter aquí
    {
        if (other.CompareTag("Enemy"))
        {
            // Destruye al enemigo solo una vez
            Destroy(other.gameObject);  // Destruye el enemigo
            gameManager.EnemyDestroyed();  // Actualiza el conteo
        }

        // Destruye la bala al colisionar con cualquier cosa
        Destroy(gameObject);
    }
}
