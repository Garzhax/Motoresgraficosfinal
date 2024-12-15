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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Actualiza el conteo y destruye el enemigo
            gameManager.EnemyDestroyed();
            Destroy(collision.gameObject);
        }

        // Destruye la bala
        Destroy(gameObject);
    }
}
