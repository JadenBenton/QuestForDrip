using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprites : MonoBehaviour
{
    public GameObject Player;
    public Animator Animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            Animator.SetInteger("Direction", 1);
        }
    }
    void FixedUpdate()
    {
        
    }
}
