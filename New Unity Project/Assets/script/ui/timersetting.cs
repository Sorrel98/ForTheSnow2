using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class timersetting : MonoBehaviour
{
    private float GameTime = 0;
    public Text GameTimeText = null;

    void Start()
    {
    }

    void Update()
    {
        Timer();
    }

    void Timer()
    {
        GameTime+=Time.deltaTime;
        GameTimeText.text = "Time : " + (int)GameTime;
        finish.time = GameTime;

        if((int)GameTime > 10)
        {
            GameTimeText.text = "게임종료";
            Debug.Log("게임 종료");
            finish.fin = true;
            SceneManager.LoadScene("체육_게임오버");
            finish.score = 3;
            return ;
        }
    }
}