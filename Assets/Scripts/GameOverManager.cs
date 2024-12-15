using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour

    public void retry()
{
    SceneManager.LoadScene(SceneManager.getactiveScene().buildIndex);
}

public void exit
{
    UnityEditor.EditorApplication.isPlaying= false;
    Application.quit;
}