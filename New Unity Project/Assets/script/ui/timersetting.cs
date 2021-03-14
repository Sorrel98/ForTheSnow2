using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class timersetting : MonoBehaviour
{
    private float GameTime = 3;
    public Text GameTimeText = null;
    public GameObject Target;
    public GameObject timer;
    public GameObject Fin;

    void Start()
    {
        Target.SetActive(true);
        timer.SetActive(false);
        Fin.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Target.SetActive(false);
        }

        if (Target.activeSelf == false)
        {
            timer.SetActive(true);
            Timer();
        }
    }

    void Timer()
    {
        GameTime-=Time.deltaTime;
        GameTimeText.text = "Time : " + (int)GameTime;

        if((int)GameTime < 0)
        {
            GameTimeText.text = "게임종료";
            Debug.Log("게임 종료");
            timer.SetActive(false);
            Fin.SetActive(true);
            return ;
        }
    }
}