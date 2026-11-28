
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayersMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 500f;
    public float movementSpeed = 200f;

    private float horizontalInput;
    private GameManager gameManager;
    private bool hasEnded;

    private void Awake()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody>();

        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        horizontalInput = 0f;

        if (Input.GetKey(KeyCode.D))
            horizontalInput = 1f;
        else if (Input.GetKey(KeyCode.A))
            horizontalInput = -1f;
    }

    private void FixedUpdate()
    {
        if (rb == null || hasEnded)
            return;

        rb.AddForce(Vector3.forward * forwardForce * Time.fixedDeltaTime);

        if (horizontalInput != 0f)
        {
            rb.AddForce(
                Vector3.right * horizontalInput * movementSpeed * Time.fixedDeltaTime,
                ForceMode.VelocityChange
            );
        }

        if (rb.position.y < -1f)
        {
            hasEnded = true;

            if (gameManager != null)
                gameManager.EndGame();
        }
    }
}
