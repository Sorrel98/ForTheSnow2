using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_5 : MonoBehaviour
{
    public float speed;
    public Vector2 speed_vec;
    // Start is called before the first frame update
    void Start()
    {
        if (WhatFloor.floor == 1)
        {
            transform.position = new Vector3(0f, -14.84f, 0f);
        }
        else if (WhatClass.classroom == 103)
        {
            transform.position = new Vector3(10.98f, 6.41f, 0f);
        }
        WhatFloor.floor = 5;
        WhatFloor.last = 5; //씬 전환
        WhatClass.classroom = 0;
        
    }

    // Update is called once per frame
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
        if (collision.gameObject.tag == "103")
        {
            WhatClass.classroom = 103;
            Debug.Log(WhatClass.classroom);
        }

    }
}
