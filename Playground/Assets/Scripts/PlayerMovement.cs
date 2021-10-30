using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float currentSpeed;
    public float walkSpeed;
    public float sprintSpeed;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;

    public float fallMultiplier;
    public float lowJumpMultiplier;

    //public ParticleSystem collectEffect;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GROUND CHECK
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //INPUT
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        //MOVEMENT
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move.normalized * currentSpeed * Time.deltaTime);
        move.Normalize();

        //SPRINT
        if(isGrounded && Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = sprintSpeed;
        }
        else
        {
            currentSpeed = walkSpeed;
        }

        //JUMP
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //BETTER JUMP
        if (velocity.y < 0)
        {
            velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (velocity.y > 0 && !Input.GetButton("Jump"))
        {
            velocity += Vector3.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }


        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //COLLECT
        if(other.gameObject.tag == "Shroom")
        {
            CollectScript.collectCount++;
            other.gameObject.SetActive(false);
            //Instantiate(collectEffect, transform.position, transform.rotation);
        }

        
    }
}
