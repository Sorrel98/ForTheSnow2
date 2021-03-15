using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMove : MonoBehaviour
{
    public float speed;
    public Vector2 speed_vec;
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        
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
            GetComponent<Rigidbody2D>().velocity = speed_vec;


        if (Target.activeSelf == true)
        {
            speed = 0;
        }
    }
}
