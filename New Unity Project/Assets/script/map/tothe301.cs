﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tothe301 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            if(class_enter.art == 0)
            {
                Debug.Log(collision.gameObject);
                SceneManager.LoadScene("미술_notice");
                WhatClass.classroom = 301;
                class_enter.art++;
            }
        }

    }
}
