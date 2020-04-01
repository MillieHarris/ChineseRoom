using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
    float speed = 6;
    float rotationSpeed = 80;
    float gravity = 8;
    float rot = 0f;
    public Rigidbody character;
    public Animator bookanim;
    public int Counter;

    Vector3 moveDir = Vector3.zero;

    CharacterController controller;
    Animator anim;
    public bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }



    void OnTriggerEnter(Collider collision)
    {
        Counter = 1;

        if (collision.CompareTag("Chair") && gameObject.tag == "Player")
        {
            print("test");
            controller.transform.position = new Vector3(-219, -328, 54);
            anim.SetInteger("condition", 3);
            bookanim.SetInteger("bookcondition", 1);
            SceneManager.LoadScene("InsideBook");
        }


    }

    void OnTriggerExit(Collider collision)
    {
        anim.SetInteger("condition", 5);
        Counter = 1;
    }


    //   void OnCollisionEnter(Collision collision)
    //   {
    //     print("test");

    //    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && (anim.GetInteger("condition") == 3))
        {
            print("hello");
           // anim.SetInteger("condition", 2);
            controller.transform.position = new Vector3(-183, -272, 310);
                
        }

        // if (controller.isGrounded)
        {

            if (Input.GetKey(KeyCode.W) && (anim.GetInteger("condition") != 3))
            {
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
                controller.transform.Translate(Vector3.forward);
                anim.SetInteger("condition", 1);

            }

            if (Input.GetKeyUp(KeyCode.W) && (anim.GetInteger("condition") != 3))
            {
                moveDir = new Vector3(0, 0, 0);
                moveDir *= speed;
                anim.SetInteger("condition", 2);
            }

            rot += Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, rot, 0);
            

            moveDir.y -= gravity * Time.deltaTime;

        }
    }
}

