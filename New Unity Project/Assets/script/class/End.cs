using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    public GameObject end1, end2, end3;
    void Start()
    {

        if (scoreSum.sum >= 15)
        {
            end1.SetActive(true);
        }
        else if (scoreSum.sum >= 10)
        {
            end2.SetActive(true);
        }
        else
        {
            end3.SetActive(true);
        }
    }
}
