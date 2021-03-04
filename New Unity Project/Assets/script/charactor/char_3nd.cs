using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_3nd : MonoBehaviour
{
    public float speed;
    public Vector2 speed_vec;


    void Start()
    {
        WhatFloor.floor = 3;
    }
    void Update()
    {
        speed_vec = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed_vec.x -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed_vec.x += speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed_vec.y += speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed_vec.y -= speed;

        }
        GetComponent<Rigidbody2D>().velocity = speed_vec;
    }

}

