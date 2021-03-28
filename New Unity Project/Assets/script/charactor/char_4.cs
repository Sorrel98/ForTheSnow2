using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_4 : MonoBehaviour
{
    public float speed;
    public Vector2 speed_vec;
    // Start is called before the first frame update
    void Start()
    {
        if (WhatFloor.floor == 1)
        {
            transform.position = new Vector3(28.11f, -3.17f, 0f);
        }
        else if (WhatClass.classroom == 102)
        {
            transform.position = new Vector3(11.41f, 2.68f, 0f);
        }
        else if(WhatClass.classroom == 101)
        {
            transform.position = new Vector3(-10.69f, 2.68f, 0f);
        }
        WhatFloor.floor = 4;
        WhatFloor.last = 4;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "101")
        {
            WhatClass.classroom = 101;
            Debug.Log(WhatClass.classroom);
        }
        else if (collision.gameObject.tag == "102")
        {
            WhatClass.classroom = 102;
            Debug.Log(WhatClass.classroom);
        }

    }

}


