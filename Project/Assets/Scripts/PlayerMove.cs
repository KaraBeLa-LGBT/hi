using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Animator animator;

    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    [SerializeField] private AudioSource footsteps;

    AudioSource playerAudio;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //  animator = GetComponent<Animator>();
    }


    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        if (Input.GetKeyDown(KeyCode.A))
            footsteps.Play();

        else if (Input.GetKeyUp(KeyCode.A))
            footsteps.Stop();
        if (Input.GetKeyDown(KeyCode.W))
            footsteps.Play();
        else if (Input.GetKeyUp(KeyCode.W))
            footsteps.Stop();
        if (Input.GetKeyDown(KeyCode.S))
            footsteps.Play();
        else if (Input.GetKeyUp(KeyCode.S))
            footsteps.Stop();
        if (Input.GetKeyDown(KeyCode.D))
            footsteps.Play();
        else if (Input.GetKeyUp(KeyCode.D))
            footsteps.Stop();



    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}