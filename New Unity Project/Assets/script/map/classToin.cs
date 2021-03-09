using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class classToin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //WhatFloor.floor = 7;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "player")
        {
            if (WhatFloor.last == 4)
            {
                SceneManager.LoadScene("1층_좌");

            }
            /*else if (lastFloor == 2)
            {
                SceneManager.LoadScene("2층");
            }
            */
            else if (WhatFloor.last == 3)
            {
                SceneManager.LoadScene("3층");
            }
            else if (WhatFloor.last == 5)
            {
                SceneManager.LoadScene("1층_위");
            }
            
            else if (WhatFloor.last == 6)
            {
                SceneManager.LoadScene("1층_우");
            }

        }

    }
}
