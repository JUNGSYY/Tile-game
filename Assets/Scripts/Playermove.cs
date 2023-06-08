using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    Rigidbody2D rb;
    private float moveH, moveV;
    public float moveSpeed = 10.0f;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveH = Input.GetAxisRaw("Horizontal") * moveSpeed;
        moveV = Input.GetAxisRaw("Vertical") * moveSpeed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(x: moveH, y: moveV).normalized;
    }
}
