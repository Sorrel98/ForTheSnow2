using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    public GameObject o;
    public GameObject x;
    public GameObject talk1;
    public GameObject talk2;
    public GameObject talk3;
    public GameObject talk4;
    public GameObject talk5;


    // Start is called before the first frame update
    void Start()
    {
        talk1.SetActive(true);
        talk2.SetActive(false);
        talk3.SetActive(false);
        talk4.SetActive(false);
        talk5.SetActive(false);
        history_score.historyNum = 1;
        history_score.historyScore = 0;
    }

    // Update is called once per frame

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("X : " + Input.mousePosition.x);
            Debug.Log("Y : " + Input.mousePosition.y);
            if (history_score.historyNum == 1)
            {
                if (Input.mousePosition.y >= 20 && Input.mousePosition.y <= 210 && Input.mousePosition.x >= 100 && Input.mousePosition.x <= 272) //오답
                {
                    history_score.historyNum++;
                    Debug.Log("오답입니다");
                    Debug.Log("number : " + history_score.historyNum);
                    Debug.Log("score : " + history_score.historyScore);
                }
                else if (Input.mousePosition.y >= 20 && Input.mousePosition.y <= 210 && Input.mousePosition.x >= 353 && Input.mousePosition.x <= 523) //정답
                {
                    history_score.historyNum++;
                    history_score.historyScore++;
                    Debug.Log("정답입니다");
                    Debug.Log("number : " + history_score.historyNum);
                    Debug.Log("score : " + history_score.historyScore);
                }
                else
                {
                    Debug.Log("이외의 곳 눌림");
                    history_score.historyNum++;
                }
                talk1.SetActive(false);
                talk2.SetActive(true);
            }
            else if (history_score.historyNum == 2)
            {
                if (Input.mousePosition.y >= 20 && Input.mousePosition.y <= 210 && Input.mousePosition.x >= 100 && Input.mousePosition.x <= 272) //정답
                {
                    history_score.historyNum++;
                    history_score.historyScore++;
                    Debug.Log("정답입니다");
                    Debug.Log("number : " + history_score.historyNum);
                    Debug.Log("score : " + history_score.historyScore);
                }
                else if (Input.mousePosition.y >= 20 && Input.mousePosition.y <= 210 && Input.mousePosition.x >= 353 && Input.mousePosition.x <= 523) //오답
                {
                    history_score.historyNum++;
                    Debug.Log("오답입니다");
                    Debug.Log("number : " + history_score.historyNum);
                    Debug.Log("score : " + history_score.historyScore);
                }
                else
                {
                    Debug.Log("이외의 곳 눌림");
                    history_score.historyNum++;
                }
                talk2.SetActive(false);
                talk3.SetActive(true);
            }
            else if (history_score.historyNum == 3)
            {
                if (Input.mousePosition.y >= 20 && Input.mousePosition.y <= 210 && Input.mousePosition.x >= 100 && Input.mousePosition.x <= 272) //오답
                {
                    history_score.historyNum++;
                    Debug.Log("오답입니다");
                    Debug.Log("number : " + history_score.historyNum);
                    Debug.Log("score : " + history_score.historyScore);
                }
                else if (Input.mousePosition.y >= 20 && Input.mousePosition.y <= 210 && Input.mousePosition.x >= 353 && Input.mousePosition.x <= 523) //정답
                {
                    history_score.historyNum++;
                    history_score.historyScore++;
                    Debug.Log("정답입니다");
                    Debug.Log("number : " + history_score.historyNum);
                    Debug.Log("score : " + history_score.historyScore);
                }
                else
                {
                    Debug.Log("이외의 곳 눌림");
                    history_score.historyNum++;
                }
                talk3.SetActive(false);
                talk4.SetActive(true);
            }
            else if (history_score.historyNum == 4)
            {
                if (Input.mousePosition.y >= 20 && Input.mousePosition.y <= 210 && Input.mousePosition.x >= 100 && Input.mousePosition.x <= 272) //오답
                {
                    history_score.historyNum++;
                    Debug.Log("오답입니다");
                    Debug.Log("number : " + history_score.historyNum);
                    Debug.Log("score : " + history_score.historyScore);
                }
                else if (Input.mousePosition.y >= 20 && Input.mousePosition.y <= 210 && Input.mousePosition.x >= 353 && Input.mousePosition.x <= 523) //정답
                {
                    history_score.historyNum++;
                    history_score.historyScore++;
                    Debug.Log("정답입니다");
                    Debug.Log("number : " + history_score.historyNum);
                    Debug.Log("score : " + history_score.historyScore);
                }
                else
                {
                    Debug.Log("이외의 곳 눌림");
                    history_score.historyNum++;
                }

                talk4.SetActive(false);
                talk5.SetActive(true);
            }
            else if (history_score.historyNum == 5)
            {
                if (Input.mousePosition.y >= 20 && Input.mousePosition.y <= 210 && Input.mousePosition.x >= 100 && Input.mousePosition.x <= 272) //정답
                {
                    history_score.historyNum++;
                    history_score.historyScore++;
                    Debug.Log("정답입니다");
                    Debug.Log("number : " + history_score.historyNum);
                    Debug.Log("score : " + history_score.historyScore);
                }
                else if (Input.mousePosition.y >= 20 && Input.mousePosition.y <= 210 && Input.mousePosition.x >= 353 && Input.mousePosition.x <= 523) //오답
                {
                    history_score.historyNum++;
                    Debug.Log("오답입니다");
                    Debug.Log("number : " + history_score.historyNum);
                    Debug.Log("score : " + history_score.historyScore);
                }
                else
                {
                    Debug.Log("이외의 곳 눌림");
                    history_score.historyNum++;
                }
                //성적표 씬 체인지
            }
        }
        

    }

}
