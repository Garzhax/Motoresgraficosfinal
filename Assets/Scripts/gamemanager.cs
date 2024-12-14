using UnityEngine;
using UnityEngine.UI; // Para UI

public class GameManager : MonoBehaviour
{
    public static int enemiesDestroyed = 0;  // Contador de enemigos eliminados
    public Text enemiesDestroyedText; // Para mostrar el contador en la UI

    void Update()
    {
        // Actualizamos la UI con el contador
        enemiesDestroyedText.text = "Enemies Destroyed: " + enemiesDestroyed;
    }
}
