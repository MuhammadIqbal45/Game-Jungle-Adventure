using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    Rigidbody rb;
    Animator _anime;
    CharacterController _controller;

    float _speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        _anime = GetComponent<Animator>();
        _controller = GetComponent<CharacterController>();    
    
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = new Vector3 (Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        direction = transform.transform.TransformDirection(direction);
        _controller.Move(direction * Time.deltaTime * _speed);

        if  (Input.GetKeyDown(KeyCode.W))
        {
            _anime.SetBool("Iswalking", true);
        }
    
        else if (Input.GetKeyUp(KeyCode.W))
        {
            _anime.SetBool("Iswalking", false);
        }

        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _anime.SetBool("Isrunning", true);
            _speed = 9.0f;
        }

        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
         _anime.SetBool("Isrunning", false);
         _speed = 9.0f;
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            _anime.SetBool("Jump", true);
        }

        else if (Input.GetKeyUp(KeyCode.Space))
        {
            _anime.SetBool("Jump", false);
        }

        Vector3 newrotation = transform.localEulerAngles;
        newrotation.y += Input.GetAxis("Mouse X");
        transform.localEulerAngles = newrotation;

    }
}
