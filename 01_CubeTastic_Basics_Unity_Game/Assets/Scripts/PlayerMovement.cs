using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    // This is a reference to the rigid body component called rb
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We marked this as FixedUpdate because we
    // are using it to mess with physics
    void FixedUpdate()
    {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //DeltaTime is the amount of seconds since the computer drew the last frame

        if ( Input.GetKey("d") ) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}


// Start is called once before the first execution of Update after the MonoBehaviour is created
//void Start()
//{
//rb.useGravity = false;
//Debug.Log("Hello World");
//  rb.AddForce(0, 200, 500);
// }
