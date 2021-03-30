using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TotheComputer : MonoBehaviour
{
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "player")
        {
            WhatClass.classroom = 101;
            SceneManager.LoadScene("컴퓨터실"); 
        }

    }
}
