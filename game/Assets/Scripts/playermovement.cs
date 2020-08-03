using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    
    public float SideForce = 500f;

    private void Update()
    {
        if (rb.transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } 

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            FindObjectOfType<obstaclemovement>().enabled = false;
            FindObjectOfType<ObstacleSpawner>().enabled = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        
    }
}
