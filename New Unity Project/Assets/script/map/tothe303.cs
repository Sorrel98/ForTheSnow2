﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tothe303 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Debug.Log(collision.gameObject);
            SceneManager.LoadScene("윤리_notice");
            WhatClass.classroom = 303;

        }

    }
}
