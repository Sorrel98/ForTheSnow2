using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class art_select : MonoBehaviour
{
    public GameObject can1_1;
    public GameObject can1_2;
    public GameObject can1_3;
    public GameObject can1_4;
    public GameObject can1_5;

    public GameObject can2_1;
    public GameObject can2_2;
    public GameObject can2_3;
    public GameObject can2_4;
    public GameObject can2_5;


    public void select_correct() //진품일 경우
    {
        if(art_total.artNum == 1)
        {
            can1_1.SetActive(false);
            can2_1.SetActive(false);

            can1_2.SetActive(true);
            can2_2.SetActive(true);
            art_total.artNum++;
            art_total.artScore++;
            Debug.Log(art_total.artScore);
            Debug.Log("진품입니다");
        }
        else if(art_total.artNum == 2)
        {
            can1_2.SetActive(false);
            can2_2.SetActive(false);

            can1_3.SetActive(true);
            can2_3.SetActive(true);
            art_total.artNum++;
            art_total.artScore++;
            Debug.Log(art_total.artScore);
            Debug.Log("진품입니다");
        }
        else if(art_total.artNum == 3)
        {
            can1_3.SetActive(false);
            can2_3.SetActive(false);

            can1_4.SetActive(true);
            can2_4.SetActive(true);
            art_total.artNum++;
            art_total.artScore++;
            Debug.Log(art_total.artScore);
            Debug.Log("진품입니다");
        }
        else if(art_total.artNum == 4)
        {
            can1_4.SetActive(false);
            can2_4.SetActive(false);

            can1_5.SetActive(true);
            can2_5.SetActive(true);
            art_total.artNum++;
            art_total.artScore++;
            Debug.Log(art_total.artScore);
            Debug.Log("진품입니다");
        }
        else if(art_total.artNum == 5)
        {
            art_total.artScore++;
            Debug.Log(art_total.artScore);
            Debug.Log("진품입니다");
            SceneManager.LoadScene("미술_게임오버");
        }
    }

    public void select_wrong() //가품일 경우
    {
        if(art_total.artNum == 1)
        {
            can1_1.SetActive(false);
            can2_1.SetActive(false);

            can1_2.SetActive(true);
            can2_2.SetActive(true);
            art_total.artNum++;
            Debug.Log(art_total.artScore);
            Debug.Log("가품입니다");
        }
        else if(art_total.artNum == 2)
        {
            can1_2.SetActive(false);
            can2_2.SetActive(false);

            can1_3.SetActive(true);
            can2_3.SetActive(true);
            art_total.artNum++;
            Debug.Log(art_total.artScore);
            Debug.Log("가품입니다");
        }
        else if(art_total.artNum == 3)
        {
            can1_3.SetActive(false);
            can2_3.SetActive(false);

            can1_4.SetActive(true);
            can2_4.SetActive(true);
            art_total.artNum++;
            Debug.Log(art_total.artScore);
            Debug.Log("가품입니다");
        }
        else if(art_total.artNum == 4)
        {
            can1_4.SetActive(false);
            can2_4.SetActive(false);

            can1_5.SetActive(true);
            can2_5.SetActive(true);
            art_total.artNum++;
            Debug.Log(art_total.artScore);
            Debug.Log("가품입니다");
        }
        else if(art_total.artNum == 5)
        {
            Debug.Log(art_total.artScore);
            Debug.Log("가품입니다");
            SceneManager.LoadScene("미술_게임오버");
        }
    }
}
