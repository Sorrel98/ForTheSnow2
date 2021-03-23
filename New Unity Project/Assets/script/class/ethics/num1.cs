using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class num1 : MonoBehaviour
{
    Button bt1;
    Button btback;

    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;

    public GameObject sit1_btn;
    public GameObject sit2_btn;
    public GameObject sit3_btn;

    public GameObject sit1;
    public GameObject sit2;
    public GameObject sit3;

    // Start is called before the first frame update
    void Start()
    {
        
        bt1 = target1.transform.GetComponent<Button>();
        btback = target4.transform.GetComponent<Button>();

        bt1.onClick.AddListener(oneClick);
        btback.onClick.AddListener(backClick);
        
    }



    void oneClick()//1번 선지
    {
        if(ethics_score.ethicsNum == 1)
        {
            sit1_btn.SetActive(false);
            sit2.SetActive(true);
            target4.SetActive(false);
            ethics_score.ethicsNum++;

        }
        else if (ethics_score.ethicsNum == 2)
        {
            sit2_btn.SetActive(false);
            sit3.SetActive(true);
            target4.SetActive(false);
            ethics_score.ethicsNum++;
        }
        else if (ethics_score.ethicsNum == 3)
        {
            Debug.Log("load game over");
            SceneManager.LoadScene("윤리_게임오버");
        }
        Debug.Log("오답");
        Debug.Log("문항 : " + ethics_score.ethicsNum);
        Debug.Log("점수 : " + ethics_score.ethicsScore);

    }
    


    void backClick()
    {
        if (ethics_score.ethicsNum == 1)
        {
            sit1.SetActive(true);
            sit1_btn.SetActive(false);
            target4.SetActive(false);
        }
        else if (ethics_score.ethicsNum == 2)
        {
            sit2.SetActive(true);
            sit2_btn.SetActive(false);
            target4.SetActive(false);
        }
        else if (ethics_score.ethicsNum == 3)
        {
            sit3.SetActive(true);
            sit3_btn.SetActive(false);
            target4.SetActive(false);
        }
    }
}
