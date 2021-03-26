using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class totheschool : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(WhatClass.classroom == 101 || WhatClass.classroom == 102)
            {
                SceneManager.LoadScene("1층_좌");
            }
            else if(WhatClass.classroom == 103)
            {
                SceneManager.LoadScene("1층_중앙");
            }
            else if(WhatClass.classroom == 104 || WhatClass.classroom == 105)
            {
                SceneManager.LoadScene("1층_우");
            }
            
        }
    }
}
