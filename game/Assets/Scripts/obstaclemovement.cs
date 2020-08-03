using UnityEngine;

public class obstaclemovement : MonoBehaviour
{
    public Rigidbody obs;
    public float ObstacleForce = 50f;
    private Vector2 screenbounds;

    public void Start()
    {
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    public void Update()
    {
        if(transform.position.z < screenbounds.y - 30)
        {
            Destroy(this.gameObject);
        }
    }
    public void FixedUpdate()
    {
        obs.AddForce(0, 0, -ObstacleForce * Time.deltaTime, ForceMode.VelocityChange);
    }

}
