using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovementRB : MonoBehaviour
{
    public float speed = 5f; //gotta go this fast

    private Rigidbody theRB; //rigid body of the character
    private Vector3 plyrInput = Vector3.zero; //what buttons/directions has the player pressed

    void Start()
    {
        theRB = GetComponent<Rigidbody>(); //rigid body
    }

    void Update()
    {
        //what buttons are being pressed?
        plyrInput = Vector3.zero;
        plyrInput.x = Input.GetAxis("Horizontal");
        plyrInput.z = Input.GetAxis("Vertical");
        //if character isn't facing the right way, make it face the right way
        if (plyrInput != Vector3.zero)
        {
            transform.forward = plyrInput;
        }

    }

    //move the character with physicsssssss
    void FixedUpdate()
    {
        theRB.MovePosition(theRB.position + plyrInput * speed * Time.fixedDeltaTime);
    }
}