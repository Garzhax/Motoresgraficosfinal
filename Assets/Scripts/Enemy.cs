using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Variable opcional para propiedades del enemigo (ejemplo: vida)
    public int health = 1;

    // M�todo para recibir da�o (por si lo necesitas)
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
        // Este m�todo queda vac�o porque el conteo se maneja en el script Bullet
    }
}
