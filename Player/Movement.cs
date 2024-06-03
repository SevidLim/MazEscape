using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject _Player;
    public Rigidbody2D rb;
    private float horizontal;
    private float speed = 5f;
    private bool moveLeft;
    private bool moveRight;

    void Start()
    {
        _Player = GameObject.Find("Player");
        rb = _Player.GetComponent<Rigidbody2D>();

        moveLeft = false;
        moveRight = false;
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        MovePlayer();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, rb.velocity.y);
    }

    public void PointerDownLeft()
    {
        moveLeft = true;
    }

    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    public void PointerDownRight()
    {
        moveRight = true;
    }

    public void PointerUpRight()
    {
        moveRight = false;
    }

    public void MovePlayer()
    {
        if (moveLeft)
        {
            horizontal = -speed;
        }
        else if (moveRight)
        {
            horizontal = speed;
        }
        else
        {
            horizontal = 0;
        }
    }
}
