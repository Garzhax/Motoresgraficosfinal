using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Contador de enemigos eliminados
    public static int enemiesDestroyed = 0;

    // Número total de enemigos en la escena
    private int totalEnemies;

    // Referencia al Canvas del mensaje "You Win"
    public GameObject youWinCanvas;

    // Referencia al Text que muestra el conteo
    public Text enemiesCountText;

    private void Start()
    {
        // Encontrar cuántos enemigos hay en la escena al inicio
        totalEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;

        // Inicializar el conteo en la UI
        UpdateEnemiesCount();

        // Asegurarse de que el Canvas de "You Win" esté desactivado al inicio
        youWinCanvas.SetActive(false);
    }

    private void Update()
    {
        // Si todos los enemigos han sido eliminados, mostrar el mensaje de "You Win"
        if (enemiesDestroyed >= totalEnemies && totalEnemies > 0)
        {
            ShowYouWin();
        }
    }

    public void UpdateEnemiesCount()
    {
        // Actualizar el texto con el conteo de enemigos
        enemiesCountText.text = $"Enemies Destroyed: {enemiesDestroyed}/{totalEnemies}";
    }

    private void ShowYouWin()
    {
        // Mostrar el Canvas de "You Win"
        youWinCanvas.SetActive(true);

        // Opcional: Pausar el juego
        Time.timeScale = 0f; // Pausa el juego
    }
}

