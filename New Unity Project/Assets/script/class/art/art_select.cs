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

    public GameObject ans1;
    public GameObject ans2;
    public GameObject ans3;
    public GameObject ans4;
    public GameObject ans5;

    public GameObject x;
    public GameObject o;



    public void select_correct() //진품일 경우
    {
        if(art_total.artNum == 1)
        {
            can1_1.SetActive(false);
            can2_1.SetActive(false);

            ans1.SetActive(true);
            o.SetActive(true);
            art_total.artNum++;
            art_total.artScore++;
            Debug.Log(art_total.artScore);
        }
        else if(art_total.artNum == 2)
        {
            can1_2.SetActive(false);
            can2_2.SetActive(false);

            ans2.SetActive(true);
            o.SetActive(true);
            art_total.artNum++;
            art_total.artScore++;
            Debug.Log(art_total.artScore);
        }
        else if(art_total.artNum == 3)
        {
            can1_3.SetActive(false);
            can2_3.SetActive(false);

            ans3.SetActive(true);
            o.SetActive(true);
            art_total.artNum++;
            art_total.artScore++;
            Debug.Log(art_total.artScore);
        }
        else if(art_total.artNum == 4)
        {
            can1_4.SetActive(false);
            can2_4.SetActive(false);

            ans4.SetActive(true);
            o.SetActive(true);
            art_total.artNum++;
            art_total.artScore++;
            Debug.Log(art_total.artScore);
        }
        else if(art_total.artNum == 5)
        {
            can1_5.SetActive(false);
            can2_5.SetActive(false);

            ans5.SetActive(true);
            o.SetActive(true);

            art_total.artScore++;
            Debug.Log(art_total.artScore);
            art_total.artNum++;
        }
    }

    public void select_wrong() //가품일 경우
    {
        if(art_total.artNum == 1)
        {
            can1_1.SetActive(false);
            can2_1.SetActive(false);

            ans1.SetActive(true);
            x.SetActive(true);
            art_total.artNum++;
            Debug.Log(art_total.artScore);
        }
        else if(art_total.artNum == 2)
        {
            can1_2.SetActive(false);
            can2_2.SetActive(false);

            ans2.SetActive(true);
            x.SetActive(true);
            art_total.artNum++;
            Debug.Log(art_total.artScore);
        }
        else if(art_total.artNum == 3)
        {
            can1_3.SetActive(false);
            can2_3.SetActive(false);

            ans3.SetActive(true);
            x.SetActive(true);
            art_total.artNum++;
            Debug.Log(art_total.artScore);
        }
        else if(art_total.artNum == 4)
        {
            can1_4.SetActive(false);
            can2_4.SetActive(false);

            ans4.SetActive(true);
            x.SetActive(true);
            art_total.artNum++;
            Debug.Log(art_total.artScore);
        }
        else if(art_total.artNum == 5)
        {
            can1_5.SetActive(false);
            can2_5.SetActive(false);

            ans5.SetActive(true);
            x.SetActive(true);
            Debug.Log(art_total.artScore);
            art_total.artNum++;
        }
    }
}
