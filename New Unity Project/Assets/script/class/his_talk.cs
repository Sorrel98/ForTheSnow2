using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class his_talk : MonoBehaviour
{

    public GameObject Talk1;
    public GameObject Talk2;
    public GameObject Talk3;
    public GameObject Talk4;
    public GameObject Talk5;
    public GameObject O;
    public GameObject X;
    // Start is called before the first frame update
    void Start()
    {
        for (int i =0; i<5; i++) //말풍선 5문제 순서대로
        {
            Talk1.SetActive(false);
            Talk2.SetActive(false);
            Talk3.SetActive(false);
            Talk4.SetActive(false);
            Talk5.SetActive(false);

            if (i == 0)
            {
                Talk1.SetActive(true);
                
            }
            else if (i == 1)
            {
                Talk2.SetActive(true);
            }
            else if (i == 2)
            {
                Talk3.SetActive(true);
            }
            else if (i == 3)
            {
                Talk4.SetActive(true);
            }
            else if (i == 4)
            {
                Talk5.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
