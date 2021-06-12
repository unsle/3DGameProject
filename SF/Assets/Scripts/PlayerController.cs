using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;
    public float rotateSpeed = 8f;

    private float xInput;
    private float zInput;

    private Vector3 movement;
    private Rigidbody playerRigidbody;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        //playerRigidbody.MovePosition(playerRigidbody.position + new Vector3(xSpeed, 0f, zSpeed));

        movement.Set(xInput, 0, zInput);
        movement = movement.normalized * speed * Time.deltaTime;

        playerRigidbody.MovePosition(transform.position + movement);
        //Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //playerRigidbody.velocity = newVelocity;

        if (xInput != 0 || zInput != 0)
            Turn();
        else return;
    }

    void Turn()
    {
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(xInput, 0, zInput));
            playerRigidbody.rotation = Quaternion.Slerp(playerRigidbody.rotation, newRotation, rotateSpeed * Time.deltaTime);
    }
}
