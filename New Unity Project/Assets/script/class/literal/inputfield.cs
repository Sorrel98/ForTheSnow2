using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputfield : MonoBehaviour
{
    public InputField input;
    string text;
    public Text txt;

    string num1 = "언제든 남을 비판하려거든 모든 세상 사람들이 네가 있던 유리한 위치에 놓여있지 않았다는 것만 기억해라.";
    string num2 = "All children, except one, grow up" ;
    string num3 = "바다는, 크레파스보다 진한, 푸르고 육중한 비늘을 무겁게 뒤채면서, 숨을 쉰다." ;


    public void submit()
    {
        text = input.text;


        if (literal_total.literalNum ==1)
        {
            if (text.Equals(num1))
            {
                Debug.Log("correct");
            }
            else
            {
                Debug.Log("fail");
            }
        }
        else if (literal_total.literalNum == 2)
        {
            if (text.Equals(num2))
            {
                Debug.Log("correct");
            }
            else
            {
                Debug.Log("fail");
            }
        }
        else if (literal_total.literalNum == 3)
        {
            if (text.Equals(num3))
            {
                Debug.Log("correct");
            }
            else
            {
                Debug.Log("fail");
            }
        }
        

        literal_total.literalNum++;
    }
}


