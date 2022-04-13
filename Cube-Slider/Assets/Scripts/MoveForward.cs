using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveForward : MonoBehaviour
{
    private Rigidbody obstacleRb;
    private bool isEndlessScene = false;
    private float speed;
    private float bottomBounds = -7.5f;

    // Start is called before the first frame update
    void Start()
    {
        obstacleRb = gameObject.GetComponent<Rigidbody>();

        if (SceneManager.GetActiveScene().name == "Endless")
        {
            isEndlessScene = true;
        }
        else
        {
            isEndlessScene = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isEndlessScene)
        {
            speed = 30f;
            obstacleRb.AddForce(-Vector3.forward * speed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (transform.position.z < bottomBounds && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
