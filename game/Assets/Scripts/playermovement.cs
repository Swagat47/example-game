using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;

    public float RightForce = 50f;
    public float LeftForce = -50f;

    private void Update()
    {
        if (rb.transform.position.y < 209)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Stationary)
            {
                double HalfScreen = Screen.width / 2.0;
                Vector3 touchPos = Camera.main.WorldToScreenPoint(touch.position);
                
                if (touchPos.x > HalfScreen)
                {
                    
                    rb.AddForce(RightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }


                else if (touchPos.x < HalfScreen)
                {
                    
                    rb.AddForce(LeftForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
            }
        }
    }
    

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(2);
        }

        
    }
}
