using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class history : MonoBehaviour
{
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        if(WhatClass.classroom == 102)
        {
            Target.SetActive(true);
        }
        else
        {
            Target.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("클릭 감지");
            SceneManager.LoadScene("역사과목");
        }
    }
}
