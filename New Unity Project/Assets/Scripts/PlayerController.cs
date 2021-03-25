using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isJump = false;
    private Rigidbody2D rb;
    public static bool isDead = false;
    public Animator animator;
    [SerializeField] private Camera cam;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            isJump = true;
            animator.SetBool("Jump", true);
        }


    }

    private void FixedUpdate()
    {
        if (isJump)
        {
            rb.velocity = new Vector2(0f, 0f);
            rb.AddForce(new Vector2(0f, 500f));
            animator.SetBool("Jump", false);
            isJump = false;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("obstacle"))
        {
            isDead = true;
        }
    }

}
