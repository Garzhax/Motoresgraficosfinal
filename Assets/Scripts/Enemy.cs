using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) // Usamos OnTriggerEnter aqu�
    {
        if (other.CompareTag("Bullet"))
        {
            // Destruye el enemigo solo si la bala lo toca
            Destroy(gameObject);  // Destruye el enemigo
        }
    }
}

