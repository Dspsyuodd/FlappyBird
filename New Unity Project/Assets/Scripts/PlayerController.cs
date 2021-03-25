using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static float h = 99f;
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

        }

    }

    private void FixedUpdate()
    {
        if (isJump)
        {
            animator.SetTrigger("Jump");
            rb.velocity = new Vector2(0f, 0f);
            rb.AddForce(new Vector2(0f, 500f));
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
