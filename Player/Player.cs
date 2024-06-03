using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //move
    private float speed = 0.005f;
    private Touch touch;

    //jump
    Rigidbody rb;
    public float jumpPower;
    Vector2 startPoint, endPoint;
    bool canJump;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //jump
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startPoint = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endPoint = Input.GetTouch(0).position;
        }

        if (endPoint.y > startPoint.y && rb.velocity.y == 0)
        {
            canJump = true;
            endPoint = Vector2.zero;
            startPoint = Vector2.zero;
        }
    }

    void FixedUpdate()
    {
        //move
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed, transform.position.y, transform.position.z);
            }
        }

        if (canJump)
        {
            rb.AddForce(Vector3.up * jumpPower);
            canJump = false;
        }
    }
}
