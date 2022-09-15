using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Move Vector
    Vector2 move;

    //Main Objects
    public GameObject Player;
    public Animator Animator;

    //RigidBody
    Rigidbody2D Body;

    //Inputs
    float horizontal; float vertical; public float runSpeed = 20.0f; float moveLimiter = 0.5f;
    void Start()
    {Body = GetComponent<Rigidbody2D>();}
    void Update()
    {
        // Gives a value between -1 and 1
        move.x = Input.GetAxisRaw("Horizontal"); // -1 is left
        move.y = Input.GetAxisRaw("Vertical"); // -1 is down

        //Diagonal Movement;

        if (Mathf.Abs(move.x) > Mathf.Abs(move.y))
        {
            move.y = 0;
        }
        else
        {
            move.x = 0;
        }

        Body.velocity = new Vector2(move.x * runSpeed, move.y * runSpeed);

        Animator.SetFloat("Horizontal", move.x);
        Animator.SetFloat("Verticle", move.y);
        Animator.SetFloat("Speed", move.sqrMagnitude);

    }
}
