using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F : MonoBehaviour
{
    public GameObject target;
    public GameObject f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, -0.1f, 0);
        /*if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }*/
        
    }
    private void OnCollisionEnter2D(Collision2D collision)

    {
        if(finish.fin == false)
        {
            if (collision.gameObject.tag == "player")
            {
                target.SetActive(true);
                f.SetActive(false);
                Destroy(gameObject);
                finish.fin = true; // 게임오버
            }
            else if (collision.gameObject.tag == "ground")
            {
                Destroy(gameObject);
            }
        }
        else if(finish.fin == true)
        {
            f.SetActive(false);
        }
        
    }
}
