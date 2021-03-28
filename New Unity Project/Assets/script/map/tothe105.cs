using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tothe105 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            if (class_enter.literal == 0)
            {
                Debug.Log(collision.gameObject);
                SceneManager.LoadScene("문학_notice");
                WhatClass.classroom = 105;
                class_enter.literal++;
            }
            

        }

    }
}
