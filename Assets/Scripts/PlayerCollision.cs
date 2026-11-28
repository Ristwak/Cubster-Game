
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayersMovement movement;

    private GameManager gameManager;
    private bool hasCollided;

    private void Awake()
    {
        if (movement == null)
            movement = GetComponent<PlayersMovement>();

        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (hasCollided)
            return;

        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            hasCollided = true;

            if (movement != null)
                movement.enabled = false;

            if (gameManager != null)
                gameManager.EndGame();
        }
    }
}
