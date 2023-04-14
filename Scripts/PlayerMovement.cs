using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 2f;
    [SerializeField] float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizonalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizonalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }


        // if (Input.GetKeyDown("space"))
        // {
        //     rb.velocity = new Vector3(0,5f,0);
        // }

        // if (Input.GetKeyDown("w"))
        // {
        //     rb.velocity = new Vector3(0,0,5f);
        // }

        // if (Input.GetKeyDown("d"))
        // {
        //     rb.velocity = new Vector3(5f,0,0);
        // }

        // if (Input.GetKeyDown("s"))
        // {
        //     rb.velocity = new Vector3(0,0,-5f);
        // }

        // if (Input.GetKeyDown("a"))
        // {
        //     rb.velocity = new Vector3(-5f,0,0);
        // }
    }
}
