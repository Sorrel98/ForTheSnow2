using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_3nd : MonoBehaviour
{
    public float speed;
    public Vector2 speed_vec;


    void Start()
    {
        if (WhatClass.classroom == 301)
        {
            transform.position = new Vector3(-4.18f, 6.51f, 0f);
        }
        else if (WhatClass.classroom == 302)
        {
            transform.position = new Vector3(6.29f, 6.31f, 0f);
        }
        else if (WhatClass.classroom == 303)
        {
            transform.position = new Vector3(18.14f, 6.51f, 0f);
        }
        else
        {
            transform.position = new Vector3(12.67f, -14.5f, 0f);
        }
        WhatFloor.floor = 3;
        WhatFloor.last = 3;
        WhatClass.classroom = 0;
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

    private void OnCollisionEnter2D(Collision2D collision) //어느 강의실 문에 부딪혔는지
    {
        if (collision.gameObject.tag == "301")
        {
            WhatClass.classroom = 301;
            Debug.Log(WhatClass.classroom);
        }
        else if (collision.gameObject.tag == "302")
        {
            WhatClass.classroom = 302;
            Debug.Log(WhatClass.classroom);
        }
        else if (collision.gameObject.tag == "303")
        {
            WhatClass.classroom = 303;
            Debug.Log(WhatClass.classroom);
        }

    }

}

