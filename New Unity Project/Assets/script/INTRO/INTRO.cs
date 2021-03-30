using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class INTRO : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;

    public int flag = 1;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(flag == 1)
            {
                target1.SetActive(false);
                target2.SetActive(true);
                flag++;
            }
            else if(flag == 2)
            {
                target2.SetActive(false);
                target3.SetActive(true);
                flag++;
            }
            else if(flag == 3)
            {
                SceneManager.LoadScene("인벤토리생성씬");
            }
            
        }

    }
}
