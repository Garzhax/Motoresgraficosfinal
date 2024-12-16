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

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;  // Prefab de la bala
    public Transform shootingPoint;  // Punto desde donde se dispara la bala

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detecta clic izquierdo del mouse
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);  // Instancia la bala
    }
}
