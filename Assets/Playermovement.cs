using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 5f;
    public float gravity = -9.8f;
    public float jumpHeight = 2f;

    private Vector3 velocity;

    void Update()
    {
        // Movimiento b�sico
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * moveSpeed * Time.deltaTime);

        // Gravedad
        if (controller.isGrounded)
        {
            velocity.y = -2f; // Para mantener al jugador tocando el suelo cuando no est� saltando
        }
        else
        {
            velocity.y += gravity * Time.deltaTime; // Si est� en el aire, aplicar gravedad
        }

        // Aplicar la gravedad
        controller.Move(velocity * Time.deltaTime);
    }
}
