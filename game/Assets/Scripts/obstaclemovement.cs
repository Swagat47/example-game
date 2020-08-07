using UnityEngine;

public class Obstaclemovement : MonoBehaviour
{
     
    public Rigidbody obs;
    public float ObstacleForce = 50f;
    
    
    public void Update()
    {
       
        if(transform.position.z < Camera.main.transform.position.z - 30)
        {
            Destroy(this.gameObject);
        }
    }
    public void FixedUpdate()
    {
        obs.AddForce(0, 0, -ObstacleForce * Time.deltaTime, ForceMode.VelocityChange);
    }

}
