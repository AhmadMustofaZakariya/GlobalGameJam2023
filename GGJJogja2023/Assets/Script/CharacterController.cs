using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 4f;
    public int jump;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        moveCharacter();
        jumpCharacter();
    }
    void moveCharacter()

    {
        
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 direction = new Vector2(horizontal, 0);
        rb.velocity = direction * speed;
    }

    public void onlanding ()
    {
        animator.SetBool("JUMPING", false);
    }
    void jumpCharacter()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
            Debug.Log("JUMP!");
        }
        
    }
}
