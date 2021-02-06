using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{

    public Rigidbody2D ballRigidbody2D;
    public float speed = 3f;
    public float jumpForce = 300f;
    public Vector2 direction;
    public Vector2 yDirection;
    public int jumpNumber = 2;

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal") * speed;
        ballRigidbody2D.AddForce(direction, ForceMode2D.Force);

        if (Input.GetButtonDown("Jump") && jumpNumber>0 )
        {
            yDirection.y = jumpForce;
            ballRigidbody2D.AddForce(yDirection, ForceMode2D.Force);
            //jumpNumber--;
        }
    }
}
