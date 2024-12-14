using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int totalEnemies;  // Número total de enemigos en la escena
    public Text enemiesRemainingText;  // Texto que muestra los enemigos restantes
    public GameObject winCanvas;  // Canvas de victoria

    private int enemiesRemaining;

    void Start()
    {
        enemiesRemaining = totalEnemies;  // Inicializa el conteo de enemigos
        UpdateEnemiesRemainingText();  // Muestra la cantidad inicial
    }

    // Este método se llama cada vez que un enemigo es destruido
    public void EnemyDestroyed()
    {
        if (enemiesRemaining <= 0) return;  // Si ya no hay enemigos, no hace nada

        enemiesRemaining--;  // Resta un enemigo
        Debug.Log("Enemigos restantes: " + enemiesRemaining);  // Muestra la cantidad restante
        UpdateEnemiesRemainingText();  // Actualiza el texto del UI

        if (enemiesRemaining <= 0)
        {
            ShowWinScreen();  // Muestra el cartel de victoria si no hay más enemigos
        }
    }

    // Actualiza el texto de "Enemigos restantes"
    private void UpdateEnemiesRemainingText()
    {
        if (enemiesRemainingText != null)
        {
            enemiesRemainingText.text = "Enemigos restantes: " + enemiesRemaining;
        }
    }

    // Muestra el cartel de victoria
    private void ShowWinScreen()
    {
        if (winCanvas != null)
        {
            winCanvas.SetActive(true);  // Activa el canvas de victoria
        }
    }
}
