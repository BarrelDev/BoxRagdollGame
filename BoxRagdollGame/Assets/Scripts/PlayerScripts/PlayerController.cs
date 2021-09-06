using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;
    public Vector2 jumpHeight;
    public LayerMask ground;
    public LayerMask wall;
    public Transform playerPos;
    public float jumpForce;
    public float playerSpeed;
    public float posistionRadius;

    private bool isGrounded;
    private bool isWall;

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
        if (Input.GetKey(KeyCode.Escape)) 
        {
            Application.Quit();
        }

        //Debug.Log(Input.GetAxis("Horizontal").ToString());
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                anim.Play("walk");
                rb.AddForce(Vector2.right * playerSpeed * Time.deltaTime);
            }
            else
            {
                anim.Play("walkBack");
                rb.AddForce(Vector2.left * playerSpeed * Time.deltaTime);
            }
        }
        else 
        {
            anim.Play("idle");
        }

        isGrounded = Physics2D.OverlapCircle(playerPos.position, posistionRadius, ground);
        isWall = Physics2D.OverlapCircle(playerPos.position, posistionRadius, wall);
        if(isGrounded && Input.GetKeyDown(KeyCode.Space)) 
        {
            if (!isWall) 
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                Debug.Log(Vector2.up * jumpForce);
            }
        }
    }
}
