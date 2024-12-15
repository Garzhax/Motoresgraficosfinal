using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Variable opcional para propiedades del enemigo (ejemplo: vida)
    public int health = 1;

    // Método para recibir daño (por si lo necesitas)
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        // Este método queda vacío porque el conteo se maneja en el script Bullet
    }
}
