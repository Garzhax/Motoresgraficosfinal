using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    private Animator animator;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>(); // Obtén el componente Animator
    }

    private void Update()
    {
        if (player != null)
        {
            agent.SetDestination(player.position);  // Enemigo persigue al jugador
            animator.SetTrigger("Run");  // Mantén la animación de correr
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            Destroy(gameObject);  // El enemigo se destruye al ser tocado por una bala
        }
    }
}
