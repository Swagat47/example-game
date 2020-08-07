using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{

    public Obstaclemovement movement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Player")
        {
            Debug.Log("collision!!");
            movement.enabled = false;
        }
    }
}
