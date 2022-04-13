using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    private float forwardForce;
    private float sidewaysForce = 100f;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Endless")
        {
            forwardForce = 0f;
        }
        else
        {
            forwardForce = 2000f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( rb.position.y < -1 )
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
