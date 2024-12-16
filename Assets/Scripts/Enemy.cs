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
        animator = GetComponent<Animator>(); // Obt�n el componente Animator
    }

    private void Update()
    {
        if (player != null)
        {
            agent.SetDestination(player.position);  // Enemigo persigue al jugador
            animator.SetTrigger("Run");  // Mant�n la animaci�n de correr
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
