using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    public float elapsedTime;

    //mobile movement
    private float touchSpeed = 0.002f; //0.002 0.005
    Touch touch;
    public bool _Jump = false;
    public bool IsGrounded = false;

    //pc movement
    private float horizontal;
    private float speed = 5f; //6
    private float jumpingPower = 5f; //5
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        _Jump = false;

        //button move
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //pc movement
        //horizontal = Input.GetAxisRaw("Horizontal");

        Flip();
    }

    private void FixedUpdate()
    {
        //elapsedTime += Time.deltaTime;
        //elapsedTime = 0f;
        //rb.velocity = new Vector2(horizontal, rb.velocity.y);

        touch = Input.GetTouch(0);

        /*if (touch.tapCount == 1 && IsGrounded && !_Jump)
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
                IsGrounded = false;
                _Jump = true;
                Debug.Log("jump");
            }
        }*/

        //touch movement
        /*if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                _Jump = false;
                rb.position = new Vector2(rb.position.x + touch.deltaPosition.x * touchSpeed, rb.position.y);
            }
        }*/
    }

    public void JumpPlayer()
    {
        if (IsGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            IsGrounded = false;
            _Jump = true;
        }
        else
        if (!IsGrounded)
        {
            touch.tapCount = 0;
            _Jump = false;
        }
    }

    private void Flip()
    {
        if(isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("ground"))
        {
            IsGrounded = true;
            _Jump = false;
        }
    }
}