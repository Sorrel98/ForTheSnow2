using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class F : MonoBehaviour
{
    public GameObject f;

    void Update()
    {
        if(finish.fin == true)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)

    {
       
        
            if (collision.gameObject.tag == "player")
            {
            Debug.Log("플레이어와 충돌");
                Destroy(gameObject);
                finish.fin = true; // 게임오버
            Debug.Log("time : " + finish.time);
            
            if (finish.time >= 10)
            {
                finish.score = 3;
            }
            else if (finish.time >=4 && finish.time < 10)
            {
                finish.score = 2;
            }
            else if(finish.time>=0 && finish.time < 4)
            {
                finish.score = 1;
            }

            Debug.Log("score : " + finish.score);
            SceneChange();
                //Invoke("SceneChange", 1f);
                

        }
            else if (collision.gameObject.tag == "ground")
            {
                Destroy(gameObject);
            }
        
        
    }
    void SceneChange()
    {
        SceneManager.LoadScene("체육_게임오버");
    }
}
