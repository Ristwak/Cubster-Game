
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded;
    private bool levelCompleted;

    public float restartDelay = 1f;
    public GameObject completeGameUI;

    public void CompleteLevel()
    {
        if (levelCompleted || gameHasEnded)
            return;

        levelCompleted = true;

        if (completeGameUI != null)
            completeGameUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded || levelCompleted)
            return;

        gameHasEnded = true;

        Invoke(nameof(Restart), restartDelay);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
