using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_6 : MonoBehaviour
{
    public float speed;
    public Vector2 speed_vec;
    // Start is called before the first frame update
    void Start()
    {
        if (WhatFloor.floor == 1)
        {
            transform.position = new Vector3(-29.57f, -3.58f, 0f);
        }
        else if (WhatClass.classroom == 104)
        {
            transform.position = new Vector3(-11.43f, 3.31f, 0f);
        }
        else if (WhatClass.classroom == 105)
        {
            transform.position = new Vector3(10.64f, 3.19f, 0f);
        }
        WhatFloor.floor = 6;
        WhatFloor.last = 6;
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
        if (collision.gameObject.tag == "104")
        {
            WhatClass.classroom = 104;
            Debug.Log(WhatClass.classroom);
        }
        else if (collision.gameObject.tag == "105")
        {
            WhatClass.classroom = 105;
            Debug.Log(WhatClass.classroom);
        }

    }
}
