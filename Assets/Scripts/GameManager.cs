using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeGameUI;
    public void CompleteLevel ()
    {
        completeGameUI.SetActive(true);
    }

    // This endgame name is not mandatory ay name can be given to the function
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            // Restarting the game
            // Restart();
            // By using the function our game restarts instantly and we couldn't see anything clearly so to make the restart delay we will use invoke
            // Invoke("Function Name",time in seconds);
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        // While restarting unity's lighting doesnt keeps-up with the scene so to make sure the lighting doesn't mess-up
        // we need to uncheck the auto button in lighting in unity and the press the build button
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
