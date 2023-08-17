using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buddy_moveset : MonoBehaviour
{
    private float speed;
    

    private Rigidbody2D rb;
    private Vector2 moveVector;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 2f;
    }

    void FixedUpdate()
    {
            moveVector.x = -1;
            moveVector.y = 0;
            rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
    }
}
