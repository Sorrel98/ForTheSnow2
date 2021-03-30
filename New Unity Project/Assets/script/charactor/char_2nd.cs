using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_2nd : MonoBehaviour
{
    public float speed;
    public Vector2 speed_vec;


    void Start()
    {
        if(WhatFloor.floor == 1)
        {
            transform.position = new Vector3(21.19f, -14.29f, 0f);
        }
        else if(WhatFloor.floor == 3)
        {
            transform.position = new Vector3(12.57f, -13.5f, 0f);
        }

        WhatFloor.floor = 2;
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

