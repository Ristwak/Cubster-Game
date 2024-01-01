using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Reference from PlayerMovement C# script
    public PlayersMovement movement;

    // OnCollisionEnter is a function created by unity itself and if spelled in a wrong manner unity will not throw any error it just wouldn't work
    void OnCollisionEnter (Collision collisionInfo)
    {
        //if (collisionInfo.collider.name == "Obstacle")
        //{
        //    Debug.Log("We hit an obstacle");
        //}



        // prefab is used when we have to create multiple same thing in the scene

        if (collisionInfo.collider.tag == "Obstacle")
        {
            //Debug.Log("We hit an obstacle");
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
