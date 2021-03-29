using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TotheClass : MonoBehaviour
{

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            if(class_enter.history == 0)
            {
                Debug.Log(collision.gameObject);
                SceneManager.LoadScene("강의실");
                class_enter.history++;
            }
            
        }

    }
}
