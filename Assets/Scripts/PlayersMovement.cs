using UnityEngine;

public class PlayersMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardforce = 500f;
    public float movementspeed = 200f;

    // Start is called before the first frame update
    void Start()
    {
        // rb.Gravity = true;
        // rb.AddForce(0, 500, 200);
    }

    // Update is called once per frame
    // If you;re doing physics stuff in unity is best to use FixedUpdate instead of Update
    void FixedUpdate()
    {
        // Now by adding this forwardforce variable we can change the speed of the object in unity as well

        // This code will only work when the user will press d in the keyboard
        // Here we are controlling the movement of the object
        // WE are multiplying the force with deltaTime as its the frame rate and it changes system by system for every person
        // so to make the game run smooth in everyones system we use this
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            // We are using Force.VelocityChange to chnage the velocity of the object when truning regardless of the mass and air-resistance
            rb.AddForce(movementspeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-movementspeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
