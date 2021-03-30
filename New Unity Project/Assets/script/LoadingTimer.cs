using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingTimer : MonoBehaviour
{
    double timer;
    double waitingTime;
 
    void Start()
    {
        timer = 0.0;
        waitingTime = 0.3;
    }
 
    void Update()
    {
        timer += Time.deltaTime;
   
        if(timer > waitingTime)
        {
            SceneManager.LoadScene("야외");
        }
    }
}
