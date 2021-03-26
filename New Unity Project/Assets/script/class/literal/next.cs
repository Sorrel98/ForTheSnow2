using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{

    public GameObject script2;
    public GameObject script3;
    public GameObject your;
    public GameObject wrong1;
    public GameObject wrong2;
    public GameObject correct;
    public GameObject nextob;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(literal_total.literalNum == 2)
            {
                script2.SetActive(true);
                wrong1.SetActive(false);
                correct.SetActive(false);
                your.SetActive(false);
                nextob.SetActive(false);
            }
            else if (literal_total.literalNum == 3)
            {
                script3.SetActive(true);
                wrong2.SetActive(false);
                correct.SetActive(false);
                your.SetActive(false);
                nextob.SetActive(false);
            }

        }
    }
}
