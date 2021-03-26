using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static float h = 99f;
    private bool isJump = false;
    private Rigidbody2D rb;
    public static bool isDead = false;
    public Animator animator;
    [SerializeField] private Camera cam;
    public Text Score;
    private int score_ = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Score.text = score_.ToString();

    }
    

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            isJump = true;

        }
        Score.text = score_.ToString();

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
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Counter"))
        {
            score_++;
        }
    }

}
