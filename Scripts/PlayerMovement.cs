 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    public CharacterController2D controller;
    public Animator animator;

    

    public Joystick joystick;

    public float runSpeed;

    float horizontalMove = 0f;

    bool jump = false;
    Rigidbody2D rb;
    bool isgrounded = true;
    bool playing;

    AudioManagerScript Aud;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Aud = FindObjectOfType<AudioManagerScript>();

    }
    // Update is called once per frame
    void Update()
    {
        if (ScoreController.counter + ScoreController.counter_2 >= 5)
        {
            Aud.Looper("Walk", false, false);
            playing = false;
        }
           /* if ((rb.velocity.y == 0 && rb.velocity.x != 0f )&& !playing)
        {
            //Debug.Log("MOVING");
            Aud.Looper("Walk", true, true);
            playing = true;
            transform.hasChanged = false;
        }

        if (rb.velocity.x == 0 || rb.velocity==Vector2.zero)
        {
            //Debug.Log("NOT MOVING");
            Aud.Looper("Walk", false, false);
            playing = false;
           // transform.hasChanged = false;
        }*/


        if (joystick.Horizontal >= .2f)
        {
            if (!playing)
            {
                Aud.Looper("Walk", true, true);
                playing = true;
            }
            horizontalMove = runSpeed;
        }

        else if (joystick.Horizontal <= -.2f)
        {
            if (!playing)
            {
                Aud.Looper("Walk", true, true);
                playing = true;
            }
            horizontalMove = -runSpeed;
        }
        else
        {
            horizontalMove = 0f;
            Aud.Looper("Walk", false, false);
            playing = false;
        }

        float verticalMove = joystick.Vertical;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        /*

        if (verticalMove >= .5f && isgrounded == true)
        {
            jump = true;
        }



        void OnCollisionEnter(Collision theCollision)
        {
            if (theCollision.gameObject.name == "Ground")
            {
                isgrounded = true;
            }
        }


        void OnCollisionExit(Collision theCollision)
        {
            if (theCollision.gameObject.name == "Ground")
            {
                isgrounded = false;
            }
        }

    }

        */
    }
    public void Jumper()
    {
        jump = true;
    
    }


    void FixedUpdate()
    {
        Debug.Log(jump);
        controller.Move(horizontalMove * Time.fixedDeltaTime ,false,jump);
        //Add Jump sound if needed.
        if (jump)
        {
           // FindObjectOfType<AudioManagerScript>().Play("Eat");
        }
        jump = false;
    }  
}
