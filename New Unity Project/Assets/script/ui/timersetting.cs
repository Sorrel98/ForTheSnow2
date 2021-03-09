using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timersetting : MonoBehaviour
{
    private float GameTime = 11;
    public Text GameTimeText =null;

    void Update()
    {
        if ((int)GameTime == 0)
        {
            GameTimeText.text = "게임종료";
            //Debug.Log("게임 종료");
        }else
        {
            GameTime -= Time.deltaTime;
            //Debug.Log((int)GameTime);
            GameTimeText.text = "Time : " + (int)GameTime;
        }
    }
}