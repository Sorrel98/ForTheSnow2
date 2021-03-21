using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class history_o : MonoBehaviour
{

    Button bt;
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
        bt = this.transform.GetComponent<Button>();
        bt.onClick.AddListener(fClick);
    }
    void fClick()
    {
        if(history_score.historyNum == 1)
        {
            //이게 눌리면 오답
            Debug.Log("문제번호:"+history_score.historyNum);
            talk1.SetActive(false);
            talk2.SetActive(true);
            history_score.historyNum++;
            
            Debug.Log("현재성적:" + history_score.historyScore);
        }
        else if(history_score.historyNum == 2)
        {
            //이게 눌리면 정답
            Debug.Log("문제번호:" + history_score.historyNum);
            talk2.SetActive(false);
            talk3.SetActive(true);
            history_score.historyScore++;
            history_score.historyNum++;
            
            Debug.Log("현재성적:" + history_score.historyScore);
        }
        else if (history_score.historyNum == 3)
        {
            Debug.Log("문제번호:" + history_score.historyNum);
            //이게 눌리면 오답
            talk3.SetActive(false);
            talk4.SetActive(true);
            history_score.historyNum++;
            
            Debug.Log("현재성적:" + history_score.historyScore);
        }
        else if (history_score.historyNum == 4)
        {
            Debug.Log("문제번호:" + history_score.historyNum);
            //이게 눌리면 오답
            talk4.SetActive(false);
            talk5.SetActive(true);
            history_score.historyNum++;
            
            Debug.Log("현재성적:" + history_score.historyScore);
        }
        else if (history_score.historyNum == 5)
        {
            //이게 눌리면 정답
            Debug.Log("문제번호:" + history_score.historyNum);
            history_score.historyScore++;
            history_score.historyNum++;
            
            Debug.Log("현재성적:" + history_score.historyScore);

            SceneManager.LoadScene("역사_게임오버");
        }
    }
    
}
