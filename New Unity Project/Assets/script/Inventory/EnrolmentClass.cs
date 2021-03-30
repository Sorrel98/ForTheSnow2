using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnrolmentClass : MonoBehaviour
{
    public static bool history = false;
    public static bool lit = false;
    public static bool art = false;
    public static bool athletic = false;
    public static bool ethics = false;

    public Button[] btnList;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enrolmentHistory()
    {
        history = true;
        btnList[0].GetComponent<Button>().interactable = false;
    }

    public void enrolmentArt()
    {
        art = true;
        btnList[1].GetComponent<Button>().interactable = false;
    }

    public void enrolmentLit()
    {
        lit = true;
        btnList[2].GetComponent<Button>().interactable = false;
    }

    public void enrolmentAthletic()
    {
        athletic = true;
        btnList[3].GetComponent<Button>().interactable = false;
    }

    public void enrolmentEthics()
    {
        ethics = true;
        btnList[4].GetComponent<Button>().interactable = false;
    }
}
