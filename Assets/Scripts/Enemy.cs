using UnityEngine;
using UnityEngine.AI;  // Importa el namespace para la navegación

public class Enemy : MonoBehaviour
{
    public Transform player;  // Referencia al jugador
    private NavMeshAgent agent;  // Componente NavMeshAgent
    public Animator animator;  // Referencia al Animator
    public ParticleSystem deathParticles;  // Referencia al sistema de partículas

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();  // Obtiene el componente NavMeshAgent
        animator = GetComponent<Animator>();  // Obtiene el componente Animator
    }

    private void Update()
    {
        if (player != null)
        {
            agent.SetDestination(player.position);  // Hace que el enemigo persiga al jugador
            animator.SetBool("isRunning", true);  // Mantiene la animación de correr activa
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            // Instancia las partículas de muerte en la posición del enemigo
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);  // Destruye el enemigo
        }
    }
}
