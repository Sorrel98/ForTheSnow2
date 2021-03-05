using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_1st : MonoBehaviour
{
    public float speed;
    public Vector2 speed_vec;
    

    void Start()
    {
        if(WhatFloor.floor == 2)
        {
            transform.position = new Vector3(17.16f, -15.38f, 0f);
        }
        else if (WhatFloor.floor == 0)
        {
            transform.position = new Vector3(2f, -15.38f, 0f);
        }
        else if(WhatFloor.floor == 4)
        {
            transform.position = new Vector3(-29.8f, -4.96f, 0f);
        }
        else if(WhatFloor.floor == 5)
        {
            transform.position = new Vector3(1.36f, 15.54f, 0f);
        }
        else if(WhatFloor.floor == 6)
        {
            transform.position = new Vector3(29.88f, -3.05f, 0f);
        }

        WhatFloor.floor = 1;

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

