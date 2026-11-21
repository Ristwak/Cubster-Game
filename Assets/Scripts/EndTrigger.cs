
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void Awake()
    {
        if (gameManager == null)
            gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (gameManager != null)
            gameManager.CompleteLevel();
    }
}
