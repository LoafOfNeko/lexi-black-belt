using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerControler : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    [SerializeField] private float speed = 5f;


    private float horizontal;
    private float vertical;

    private bool isWalking = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (horizontal != 0 || vertical != 0)
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }
        animator.SetFloat("x", horizontal);
        animator.SetFloat("y", vertical);

        animator.SetBool("isWalking", isWalking);


        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
