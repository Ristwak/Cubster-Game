
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    private void LateUpdate()
    {
        if (player == null)
            return;

        transform.position = player.position + offset;
    }
}
