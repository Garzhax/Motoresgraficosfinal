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
            // Destruye al enemigo solo una vez
            Destroy(collision.gameObject);  // Destruye el enemigo
            gameManager.EnemyDestroyed();  // Actualiza el conteo
        }

        // Destruye la bala
        Destroy(gameObject);
    }
}
