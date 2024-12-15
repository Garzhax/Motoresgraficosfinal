using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    private NavMeshAgent agent; // Componente NavMeshAgent
    public GameObject explosionParticles; // Prefab de las partículas de explosión

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>(); // Obtiene el componente NavMeshAgent
    }

    private void Update()
    {
        // Si el jugador está cerca, el enemigo lo sigue
        if (player != null)
        {
            agent.SetDestination(player.position); // Hace que el enemigo persiga al jugador
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            // Instancia las partículas de explosión en la posición del enemigo
            Instantiate(explosionParticles, transform.position, Quaternion.identity);

            Destroy(gameObject);  // Destruye el enemigo si es tocado por una bala
        }
    }
}
