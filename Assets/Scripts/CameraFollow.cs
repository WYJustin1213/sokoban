using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Assign your player GameObject in the Inspector
    public Vector3 offset;   // Adjust this in the Inspector to set the camera's position relative to the player

    void LateUpdate()
    {
        // Update the camera's position based on the player's position and the defined offset
        transform.position = player.position + offset;
    }
}
