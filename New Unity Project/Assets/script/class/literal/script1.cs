﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    public GameObject script;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject canvas;
    public GameObject notebook;
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            script.SetActive(false);
            target1.SetActive(true);
            target2.SetActive(true);
            target3.SetActive(true);
            canvas.SetActive(true);
            notebook.SetActive(true);
        }
        
    }
}
