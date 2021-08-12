using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;
    public float jumpForce;
    public float playerSpeed;
    public Vector2 jumpHeight;
    private bool isGrounded;
    public float posistionRadius;
    public LayerMask ground;
    public Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        Collider2D[] colliders = transform.GetComponentsInChildren<Collider2D>();
        for (int i = 0; i < colliders.Length; i++) 
        {
            for (int k = i + 1; k < colliders.Length; k++) 
            {
                Physics2D.IgnoreCollision(colliders[i], colliders[k]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxis("Horizontal").ToString());
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                anim.Play("walk");
                rb.AddForce(Vector2.right * playerSpeed);
            }
            else
            {
                anim.Play("walkBack");
                rb.AddForce(Vector2.left * playerSpeed);
            }
        }
        else 
        {
            anim.Play("idle");
        }

        isGrounded = Physics2D.OverlapCircle(playerPos.position, posistionRadius, ground);
        if(isGrounded == true && Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("jumping");
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
}
