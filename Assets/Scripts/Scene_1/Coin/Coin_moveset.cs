using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_moveset : MonoBehaviour
{
    public float speed;
    public float time;

    public static bool motion_is_finished;

    private Rigidbody2D rb;
    private Vector2 moveVector;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        motion_is_finished = false;
    }

    void Update()
    {
        if (time > 0)
        {
            moveVector.x = 0;
            moveVector.y = 1;
            rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
            time -= Time.deltaTime;
        }
        else if (!motion_is_finished && time <= 0) 
        { 
            motion_is_finished = true;
        }
    }
}
