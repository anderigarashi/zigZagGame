using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ballController : MonoBehaviour
{
    [Header("Player Refs")]
    [SerializeField] private float speed = 0.2f;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private gameData gameValues;
    public TextMeshProUGUI txt;
    public static bool gameOver = false;
    private int coinsNum = 0;
    
    void Start()
    {
        rb.velocity = new Vector3(speed, 0, 0);
        StartCoroutine(AdsjutSpeed());
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

        txt.text = speed.ToString();
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
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "coin")
        {
            Destroy(col.gameObject);
            gameValues.coins++;
            //Update UI
            //coinsNum++;
        }
    }

    IEnumerator AdsjutSpeed()
    {
        while(!gameOver)
        {
            yield return new WaitForSeconds(2);
            speed += 0.2f;
        }
    }
}
