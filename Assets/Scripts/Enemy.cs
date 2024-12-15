using UnityEngine;
using UnityEngine.AI;  // Importa el namespace para la navegación

public class Enemy : MonoBehaviour
{
    public Transform player;  // Referencia al jugador
    private NavMeshAgent agent;  // Componente NavMeshAgent

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();  // Obtiene el componente NavMeshAgent
    }

    private void Update()
    {
        // Si el jugador está cerca, el enemigo lo sigue
        if (player != null)
        {
            agent.SetDestination(player.position);  // Hace que el enemigo persiga al jugador
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            Destroy(gameObject);  // Destruye el enemigo si es tocado por una bala
        }
    }
}
