using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public GameObject bulletPrefab;  // El prefab de la bala
    public Transform shootPoint;     // El punto desde donde sale la bala
    public float bulletSpeed = 50f;  // La velocidad de la bala
    public float fireRate = 0.5f;   // El tiempo entre disparos

    private float nextTimeToFire = 0f;

    void Update()
    {
        // Detecta cuando se presiona el botón de disparo (por defecto es el clic izquierdo del mouse)
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            Shoot();
            nextTimeToFire = Time.time + 1f / fireRate; // Establece el intervalo entre disparos
        }
    }

    void Shoot()
    {
        // Crear una bala desde el punto de disparo
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.velocity = shootPoint.forward * bulletSpeed; // Da velocidad a la bala
        }
    }
}
