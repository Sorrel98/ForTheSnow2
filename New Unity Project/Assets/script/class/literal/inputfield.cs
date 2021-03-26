using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputfield : MonoBehaviour
{
    public InputField input;
    string text="";
    public Text your_text;

    string num1 = "언제든 남을 비판하려거든 모든 세상 사람들이 네가 있던 유리한 위치에 놓여있지 않았다는 것만 기억해라.";
    string num2 = "All children, except one, grow up." ;
    string num3 = "바다는, 크레파스보다 진한, 푸르고 육중한 비늘을 무겁게 뒤채면서, 숨을 쉰다." ;
    

    public GameObject wrong1;
    public GameObject wrong2;
    public GameObject wrong3;
    public GameObject correct;

    public GameObject script1;
    public GameObject inputf;
    public GameObject re;
    public GameObject sub;
    public GameObject notebook;
    public GameObject your;

    public GameObject next;
    public GameObject fin;

    public void submit()
    {
        text = input.text;


        if (literal_total.literalNum ==1)
        {
            if (text.Equals(num1))
            {
                
                correct.SetActive(true);
                //script1.SetActive(false);
                inputf.SetActive(false);
                re.SetActive(false);
                sub.SetActive(false);
                notebook.SetActive(false);
                next.SetActive(true);

                literal_total.literalScore++;
                Debug.Log("correct");
                Debug.Log(literal_total.literalScore);
            }
            else
            {
                your_text.text = text;
                Debug.Log("fail");
                wrong1.SetActive(true);
                notebook.SetActive(false);
                re.SetActive(false);
                sub.SetActive(false);
                inputf.SetActive(false);
                your.SetActive(true);
                next.SetActive(true);

            }
        }
        else if (literal_total.literalNum == 2)
        {
            if (text.Equals(num2))
            {

                correct.SetActive(true);
                //script1.SetActive(false);
                inputf.SetActive(false);
                re.SetActive(false);
                sub.SetActive(false);
                notebook.SetActive(false);
                next.SetActive(true);

                literal_total.literalScore++;
                Debug.Log("correct");
                Debug.Log(literal_total.literalScore);
            }
            else
            {
                your_text.text = text;
                Debug.Log("fail");
                wrong2.SetActive(true);
                notebook.SetActive(false);
                re.SetActive(false);
                sub.SetActive(false);
                inputf.SetActive(false);
                your.SetActive(true);
                next.SetActive(true);
            }
        }
        else if (literal_total.literalNum == 3)
        {
            if (text.Equals(num3))
            {

                correct.SetActive(true);
                //script1.SetActive(false);
                inputf.SetActive(false);
                re.SetActive(false);
                sub.SetActive(false);
                notebook.SetActive(false);
                fin.SetActive(true);

                literal_total.literalScore++;
                Debug.Log("correct");
                Debug.Log(literal_total.literalScore);
            }
            else
            {
                your_text.text = text;
                Debug.Log("fail");
                wrong3.SetActive(true);
                notebook.SetActive(false);
                re.SetActive(false);
                sub.SetActive(false);
                inputf.SetActive(false);
                your.SetActive(true);
                fin.SetActive(true);
            }
        }
        

        literal_total.literalNum++;
    }
}


