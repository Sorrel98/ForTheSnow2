using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class art_answer : MonoBehaviour
{
    // Start is called before the first frame update
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

    public GameObject o;
    public GameObject x;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(art_total.artNum == 2)
            {
                gameObject.SetActive(false);
                can1_2.SetActive(true);
                can2_2.SetActive(true);
                o.SetActive(false);
                x.SetActive(false);

            }
            else if(art_total.artNum == 3)
            {
                gameObject.SetActive(false);
                can1_3.SetActive(true);
                can2_3.SetActive(true);
                o.SetActive(false);
                x.SetActive(false);
            }
            else if (art_total.artNum == 4)
            {
                gameObject.SetActive(false);
                can1_4.SetActive(true);
                can2_4.SetActive(true);
                o.SetActive(false);
                x.SetActive(false);
            }
            else if (art_total.artNum == 5)
            {
                gameObject.SetActive(false);
                can1_5.SetActive(true);
                can2_5.SetActive(true);
                o.SetActive(false);
                x.SetActive(false);
            }
            else if(art_total.artNum == 6)
            {
                Debug.Log("왜 안 넘어가");
                SceneManager.LoadScene("미술_게임오버");
            }


        }
    }
}
