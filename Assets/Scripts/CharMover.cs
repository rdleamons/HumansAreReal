﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMover : MonoBehaviour
{
    public float speed;                //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;        //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void Update()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float dirX = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float dirY = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos.x += speed * dirX;
        pos.y += speed * dirY;
        transform.position = pos;
    }
}
