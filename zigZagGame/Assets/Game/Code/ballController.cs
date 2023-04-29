using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    [Header("Player Refs")]
    [SerializeField] private float speed = 0.2f;
    [SerializeField] private Rigidbody rb;
    [SerializeField] public static bool gameOver = false;
    
    void Start()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            BallMovement();
        }

        if(!Physics.Raycast(transform.position, Vector3.down, 1))
        {
            gameOver = true;
            rb.useGravity = true;
        }
        if(gameOver)
        {
            print("gameOver");
        }
        Debug.DrawRay(transform.position, Vector3.down, Color.red);
    }

    void BallMovement()
    {
        if(rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
        else if(rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }
    }
}
