using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float mouseSensitivity = 2f;  // Sensibilidad del mouse
    public float moveSpeed = 5f;         // Velocidad de movimiento
    private float xRotation = 0f;        // Rotaci�n en el eje X
    private Transform playerBody;        // Cuerpo del jugador para rotaci�n horizontal
    private Rigidbody rb;

    void Start()
    {
        // Obtenemos el cuerpo del jugador (el objeto principal que contiene la c�mara)
        playerBody = transform.parent;
        Cursor.lockState = CursorLockMode.Locked; // Bloqueamos el cursor al centro de la pantalla
        Cursor.visible = false;                  // Ocultamos el cursor
    }

    void Update()
    {
        // Movimiento de la c�mara
        float horizontal = Input.GetAxis("Horizontal"); // A y D o flechas izquierda/derecha
        float vertical = Input.GetAxis("Vertical");     // W y S o flechas arriba/abajo

        // Movimiento del jugador
        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        transform.parent.Translate(move * moveSpeed * Time.deltaTime, Space.World);

        // Rotaci�n de la c�mara con el mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Rotaci�n en el eje Y (horizontal) para el cuerpo del jugador
        playerBody.Rotate(Vector3.up * mouseX);

        // Rotaci�n en el eje X (vertical) para la c�mara
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // Limitar la rotaci�n vertical
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
