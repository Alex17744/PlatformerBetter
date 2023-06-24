using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    public LayerMask enemyLayerMask;

    public float speed = 0.5f;
    public float jumpForce = 1f;
    public bool isGrounded = false;
    public float dashForce = 5f;
    public float cooldownTime = 2f;
    public float attackDistance = 0.3f;
    public float DashOP = 5f;

    public GameObject projectilePrefab;

    private float nextDashTime = 0;



    private HUDManager hudManager;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;

    private Vector2 direction = Vector2.right;

    // Start is called before the first frame update
    void Start()
    {
        hudManager = GetComponent<HUDManager>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
            spriteRenderer.flipX = false;
            direction = Vector2.right;
            animator.SetBool("IsMoving", true);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
            spriteRenderer.flipX = true;
            direction = Vector2.left;
            animator.SetBool("IsMoving", true);
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            animator.Play("Player Attack");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            Quaternion rotation = direction == Vector2.right ?Quaternion.identity 
                : Quaternion.Euler(0f, 180f, 0f);

            Instantiate(projectilePrefab, transform.position + (Vector3)direction * 0.15f, rotation);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (Time.time > nextDashTime)
            {
                rb.AddForce(direction * DashOP, ForceMode2D.Impulse);
                nextDashTime = Time.time + cooldownTime;
                print("ez");
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            hudManager.TakeDamage();
        }
    }

    public void Attack()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackDistance, enemyLayerMask);
        if (hit)
        {
            Destroy(hit.transform.gameObject);
        }
    }

    public void Burn()
    {
        
    }
}

  