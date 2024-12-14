using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float mouseSensitivity = 2f;  // Sensibilidad del mouse
    public float moveSpeed = 5f;         // Velocidad de movimiento
    private float xRotation = 0f;        // Rotación en el eje X
    private Transform playerBody;        // Cuerpo del jugador para rotación horizontal
    private Rigidbody rb;

    void Start()
    {
        // Obtenemos el cuerpo del jugador (el objeto principal que contiene la cámara)
        playerBody = transform.parent;
        Cursor.lockState = CursorLockMode.Locked; // Bloqueamos el cursor al centro de la pantalla
        Cursor.visible = false;                  // Ocultamos el cursor
    }

    void Update()
    {
        // Movimiento de la cámara
        float horizontal = Input.GetAxis("Horizontal"); // A y D o flechas izquierda/derecha
        float vertical = Input.GetAxis("Vertical");     // W y S o flechas arriba/abajo

        // Movimiento del jugador
        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        transform.parent.Translate(move * moveSpeed * Time.deltaTime, Space.World);

        // Rotación de la cámara con el mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Rotación en el eje Y (horizontal) para el cuerpo del jugador
        playerBody.Rotate(Vector3.up * mouseX);

        // Rotación en el eje X (vertical) para la cámara
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // Limitar la rotación vertical
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
