using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 500f;
    public float moveSpeed = 50f;
    bool moveRight = false;
    bool moveLeft = false;




    void Update()
    {
        if (Input.GetKey("d"))
        {
            moveRight = true;
        }
        else
        {
            moveRight = false;
        }

        if (Input.GetKey("a"))
        {
            moveLeft = true;
        }
        else
        {
            moveLeft = false;
        }
    }


    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (moveRight == true)
        {
            rb.AddForce(moveSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (moveLeft == true)
        {
            rb.AddForce(-moveSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
