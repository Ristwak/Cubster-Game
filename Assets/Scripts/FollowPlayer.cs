using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    // Using this we are adding 3 vector values
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // Debug.Log();    is used to give output in console of unity

        // This line of code means that we are fixing the position of the camera ( as the camera is linked with this script file ) with the positionof the object(player)
        // Using the code we can access the first-person view 
        transform.position = player.position + offset;
    }
}
